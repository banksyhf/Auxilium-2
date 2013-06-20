using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Auxilium.Core;
using Auxilium.Core.Packets;
using Auxilium.Core.Packets.ClientPackets;
using Auxilium.Core.Packets.ServerPackets;
using Auxilium_Server.SQL;

namespace Auxilium_Server
{
    internal class Program
    {
        private static Server _server;

        private const string HashAlrogithm = "SHA1";

        private static DateTime _lastBackup;

        private static System.Threading.Timer _chatMonitor;

        private static Dictionary<byte, List<BroadcastMessage>> _recentMessages = new Dictionary<byte, List<BroadcastMessage>>();

        private static void Main(string[] args)
        {
            Accessor.ConnectionString =
#if DEBUG //Debugging on your own computer, using your own MsSQL database.
 @"Data Source=Banksy-PC\SQLEXPRESS;Initial Catalog=aux2;Persist Security Info=True;User ID=auxilium;Password=123456";
#else //Release version, for your server's MsSQL database.
 @"Data Source=WIN-2OAHGBMYAML\SQLEXPRESS;Initial Catalog=aux2;User ID=auxilium;Password=123456";
#endif

            Channel[] channels = Accessor.GetChannels();
            foreach (Channel channel in channels)
                _recentMessages.Add(channel.Id, new List<BroadcastMessage>());

            _server = new Server(bufferSize: 8192, maxConnections: 5000);

            _server.AddTypesToSerializer(typeof(IPacket), new Type[]
            {
                typeof(Initialize),
                typeof(Login), typeof(LoginResponse),
                typeof(Register), typeof(RegisterResponse),
                typeof(ChannelListRequest), typeof(ChannelList), typeof(ChangeChannel),
                typeof(ClientMessage), typeof(BroadcastMessage),
            });

            _server.ClientRead += ClientRead;
            _server.ClientState += ClientState;

            _server.Listen(35);

            _chatMonitor = new System.Threading.Timer(Monitor, null, 1000, 60000); //240,000 = 4 Minutes

            Application.Run();
        }

        private static void ClientState(Server server, Client client, bool connected)
        {
            Console.WriteLine("{0}connected", connected ? "" : "dis");
            if (connected)
            {
                client.Value = new UserState();

                new Initialize(HashAlrogithm).Execute(client);
            }
            else
            {
                HandleClientDisconnected(client);
                client = null;
            }
        }

        private static void ClientRead(Server server, Client client, IPacket packet)
        {
            if (client.Value.IsFlooding())
                client.Disconnect();

            Type packetType = packet.GetType();

            if (client.Value.Authenticated)
            {
                if (packetType == typeof(ClientMessage))
                {
                    HandleClientMessage(client, (ClientMessage)packet);
                }
                else if (packetType == typeof(ChannelListRequest))
                {
                    SendChannels(_server.Clients);
                }
                else if (packetType == typeof(ChangeChannel))
                {
                    HandleChangeChannelPacket(client, (ChangeChannel)packet);
                }
            }
            else
            {
                if (packetType == typeof(Register))
                {
                    HandleRegisterPacket(client, (Register)packet);
                }
                else if (packetType == typeof(Login))
                {
                    HandleLoginPacket(client, (Login)packet);
                }
            }
        }

        #region " Monitor "

        private static void Monitor(object state)
        {
            if (!_server.Listening)
                return;

            UpdateAndSaveUsers(false);
        }

        private static void AwardPoints(Client c)
        {
            if ((DateTime.Now - c.Value.LastAction).TotalMinutes >= 3)
            {
                c.Value.Idle = true;
            }

            //2812000 at 4.65 points per second should require about 1 week of active time to max rank.
            double points = (DateTime.Now - c.Value.LastPayout).TotalSeconds * 4.65;
            c.Value.LastPayout = DateTime.Now;

            if (c.Value.Idle)
            {
                if (c.Value.Rank < 29)
                    c.Value.AddPoints((int)points);
            }
            else
            {
                c.Value.AddPoints((int)points);
            }
        }

        private static void UpdateAndSaveUsers(bool shutDown)
        {
            bool doBackup = false;
            if ((DateTime.Now - _lastBackup).TotalMinutes >= 2)
            {
                doBackup = true;
                _lastBackup = DateTime.Now;
            }

            doBackup = true;

            foreach (Client c in _server.Clients)
            {
                if (!c.Value.Authenticated) continue;

                AwardPoints(c);

                if (!shutDown)
                {
                    SendChannels(_server.Clients);
                }

                if (doBackup || shutDown)
                {
                    Accessor.UpdateRank(c.Value.Username, c.Value.Points, c.Value.Rank);
                }
            }
        }

        #endregion " Monitor "

        #region " Packet Handlers "

        private static void HandleLoginPacket(Client client, Login packet)
        {
            //Get a matching user from the database with the username and password.
            User user = Accessor.GetUser(packet.Username, packet.Password);

            bool success = user != null;

            string message = success ? null : "Username or password is incorrect.";
            int errorCode = success ? (int)MessageBoxIcon.None : (int)MessageBoxIcon.Error;

            new LoginResponse(success, message, errorCode).Execute(client);

            if (success)
            {
                _server.Clients
                    .Where(x => x.Value.Username == user.Username && x != client)
                    .ToList()
                    .ForEach(x => x.Disconnect());

                client.Value.Username = user.Username;
                client.Value.Channel = 1;
                client.Value.Authenticated = true;
                client.Value.ID = user.Id;
                client.Value.Points = user.Points;
                client.Value.Rank = user.Rank;

                SendChannels(_server.Clients);
                SendRecentMessages(client);
            }
        }

        private static void HandleRegisterPacket(Client client, Register packet)
        {
            if (string.IsNullOrWhiteSpace(packet.Username))
            {
                new RegisterResponse(false, "Username must not be empty.", (int)MessageBoxIcon.Error).Execute(client);
                return;
            }
            else if (string.IsNullOrWhiteSpace(packet.Password))
            {
                new RegisterResponse(false, "Password must not be empty.", (int)MessageBoxIcon.Error).Execute(client);
                return;
            }
            else if (string.IsNullOrWhiteSpace(packet.Email))
            {
                new RegisterResponse(false, "Email must not be empty.", (int)MessageBoxIcon.Error).Execute(client);
                return;
            }

            bool success = Accessor.InsertUser(packet.Username, packet.Password, packet.Email);

            string message = success ? null : "Another user already exists with that username and/or email.";

            int errorCode = success ? (int)MessageBoxIcon.None : (int)MessageBoxIcon.Error;

            new RegisterResponse(success, message, errorCode).Execute(client);
        }

        private static void HandleChangeChannelPacket(Client client, ChangeChannel packet)
        {
            client.Value.Channel = packet.ID;
            SendChannels(_server.Clients);

            SendRecentMessages(client);
        }

        private static void HandleClientMessage(Client client, ClientMessage packet)
        {
            client.Value.AddPoints(5); //AWARD 5 POINTS FOR ACTIVITY***

            BroadcastMessage message = new BroadcastMessage(packet.Message, client.Value.Username, client.Value.ID);
            foreach (Client c in _server.Clients)
            {
                if (c != client && c.Value.Channel == client.Value.Channel)
                {
                    message.Execute(c);
                }
            }
            AddMessageToRecent(message, client.Value.Channel);
        }

        #endregion " Packet Handlers "

        #region " Helper Methods "

        private static void SendRecentMessages(Client client)
        {
            var messages = _recentMessages.Where(x => x.Key == client.Value.Channel);

            foreach (var message in messages.ToArray()[0].Value)
                message.Execute(client);
        }

        private static void SendChannels(params Client[] clients)
        {
            ChannelList list = new ChannelList(GetChannels());
            foreach (Client client in clients)
                if (client.Value.Authenticated)
                {
                    list.CurrentChannel = client.Value.Channel;
                    list.Execute(client);
                }
            list.Dispose();
        }

        private static ChannelInfo[] GetChannels()
        {
            Channel[] channels = Accessor.GetChannels();
            List<ChannelInfo> channelInfos = new List<ChannelInfo>();
            foreach (Channel channel in channels)
                channelInfos.Add(new ChannelInfo(channel.Name, channel.Id, GetUsersFromChannel(channel)));
            return channelInfos.ToArray();
        }

        private static UserInfo[] GetUsersFromChannel(Channel channel)
        {
            List<UserInfo> users = new List<UserInfo>();
            foreach (Client client in _server.Clients)
                if (client.Value.Channel == channel.Id)
                    users.Add(new UserInfo(client.Value.Username, client.Value.Rank, client.Value.ID));
            return users.ToArray();
        }

        private static void AddMessageToRecent(BroadcastMessage message, byte channelID)
        {
            _recentMessages.First(x => x.Key == channelID).Value.Add(message);
        }

        #endregion " Helper Methods "

        private static void HandleClientDisconnected(Client client)
        {
            client.Value.Authenticated = false;
            client.Value.Channel = 0;
            client.Value.Username = null;
            SendChannels(_server.Clients);
        }
    }
}