using Auxilium.Core;
using Auxilium.Core.Packets;
using Auxilium.Core.Packets.ClientPackets;
using Auxilium.Core.Packets.ServerPackets;
using Auxilium_Server.SQL;
using System;
using System.Windows.Forms;

namespace Auxilium_Server
{
    internal class Program
    {
        private static Server Server { get; set; }

        private const string HashAlrogithm = "SHA1";

        private static void Main(string[] args)
        {
            Server = new Server(8192, 500);

            Server.AddTypesToSerializer(typeof(IPacket), new Type[]
            {
                typeof(Initialize),
                typeof(Login), typeof(LoginResponse),
                typeof(Register), typeof(RegisterResponse),
                typeof(ClientMessage), typeof(BroadcastMessage)
            });

            Server.ClientRead += ClientRead;
            Server.ClientState += ClientState;

            Server.Listen(35);

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
            }
        }

        private static void ClientRead(Server server, Client client, IPacket packet)
        {
            Type packetType = packet.GetType();

            if (client.Value.Authenticated)
            {
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
                else if (packetType == typeof(ClientMessage))
                {
                }
            }
        }

        #region " Packet Handlers "

        private static void HandleLoginPacket(Client client, Login packet)
        {
            //Get a matching user from the database with the username and password.
            User user = Accessor.GetUser(packet.Username, packet.Password);

            bool success = user != null;

            string message = success ? null : "Username or password is incorrect.";
            int errorCode = success ? (int)MessageBoxIcon.None : (int)MessageBoxIcon.Error;

            new LoginResponse(success, message, errorCode).Execute(client);
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

        #endregion " Packet Handlers "

        private static void HandleClientDisconnected(Client client)
        {
        }
    }
}