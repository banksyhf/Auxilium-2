using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using Auxilium.Core;
using Auxilium.Core.Packets;
using Auxilium.Core.Packets.ClientPackets;
using Auxilium.Core.Packets.ServerPackets;
using Auxilium.Forms;

namespace Auxilium
{
    internal static class Program
    {
        private static Client Client { get; set; }

        private static frmMain MainForm { get; set; }

        [STAThread]
        private static void Main()
        {
            if (File.Exists("updater.exe"))
            {
                TryStartNewThread(new Action(() => { Thread.Sleep(500); File.Delete("updater.exe"); }));
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm = new frmMain(Client);
            Connect();

            Application.Run(MainForm);
        }

        public static void Connect()
        {
            if (Client != null)
                Client.Disconnect();

            Client = new Client(bufferSize: 8192);

            Client.AddTypesToSerializer(typeof(IPacket), new Type[]
            {
                typeof(Initialize),
                typeof(Login), typeof(LoginResponse),
                typeof(Register), typeof(RegisterResponse),
                typeof(ChannelListRequest), typeof(ChannelList), typeof(ChangeChannel),
                typeof(ClientMessage), typeof(BroadcastMessage),
            });

            Client.ClientState += ClientState;
            Client.ClientRead += ClientRead;
            Client.ClientFail += ClientFail;

#if DEBUG
            Client.Connect("127.0.0.1", 35);
#else
            Client.Connect("50.115.161.154", 35);
#endif

            if (MainForm != null)
                MainForm.Client = Client;
        }

        private static void ClientState(Client client, bool connected)
        {
            if (connected)
            {
                if (MainForm != null)
                {
                    MainForm.ChangeTab(MainIndex.Login);
                    MainForm.UpdateStatus("Status: Connected.");
                }
            }
            else
            {
                if (MainForm != null)
                {
                    MainForm.ChangeTab(MainIndex.Reconnect);
                    MainForm.UpdateStatus("Status: Connection failed.");
                    MainForm.Initialized = false;
                }
            }
        }

        private static void ClientFail(Client client)
        {
            if (MainForm != null)
            {
                MainForm.UpdateStatus("Status: Connection failed.");
                MainForm.ChangeTab(MainIndex.Reconnect);
                MainForm.Initialized = false;
            }
        }

        private static void ClientRead(Client client, IPacket packet)
        {
            try
            {
                Type type = packet.GetType();

                if (type == typeof(Initialize))
                {
                    client.HashAlgorithm = HashAlgorithm.Create(((Initialize)packet).HashAlgorithm);
                    MainForm.Initialized = true;
                }
                else if (type == typeof(LoginResponse))
                {
                    MainForm.HandleLoginResponse((LoginResponse)packet);
                }
                else if (type == typeof(RegisterResponse))
                {
                    MainForm.HandleRegisterResponse((RegisterResponse)packet);
                }
                else if (type == typeof(ChannelList))
                {
                    MainForm.HandleChannelList((ChannelList)packet);
                }
                else if (type == typeof(BroadcastMessage))
                {
                    MainForm.HandleBroadcastMessage((BroadcastMessage)packet);
                }
            }
            catch
            {
            }
        }

        private static void TryStartNewThread(Action action)
        {
            new Thread(() =>
            {
                try { action.Invoke(); }
                catch { }
            }) { IsBackground = true }.Start();
        }
    }
}