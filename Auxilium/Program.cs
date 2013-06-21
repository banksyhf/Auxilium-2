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

            Application.ApplicationExit += Application_ApplicationExit;

            Application.Run(MainForm);
        }

        static void Application_ApplicationExit(object sender, EventArgs e)
        {
            if (MainForm != null && MainForm.notifyIcon != null)
            {
                try
                {
                    MainForm.notifyIcon.Visible = false;
                    MainForm.notifyIcon = null;
                }
                catch
                {
                }
            }
        }

        public static void Connect()
        {
            if (Client != null)
                Client.Disconnect();

            Client = new Client
            {
                BufferSize = 8192
            };

            Client.AddTypesToSerializer(typeof(IPacket), new Type[]
            {
                typeof(Initialize), typeof(KeepAlive),
                typeof(Login), typeof(LoginResponse),
                typeof(Register), typeof(RegisterResponse),
                typeof(ChannelListRequest), typeof(ChannelList), typeof(ChangeChannel),
                typeof(ClientMessage), typeof(BroadcastMessage),
                typeof(Suggestion), typeof(SuggestionResponse),
                typeof(PrivateMessage), typeof(PrivateMessageCountRequest), typeof(PrivateMessagesRequest)
            });

            Client.ClientState += ClientState;
            Client.ClientRead += ClientRead;
            Client.ClientFail += ClientFail;

#if DEBUG
            Client.Connect("127.0.0.1", 35);
#else
            Client.Connect("50.115.161.154", 35);
#endif

            TryStartNewThread(new Action(() => { while (true) { if (Client.Connected) new KeepAlive().Execute(Client); Thread.Sleep(25000); } }));

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

                    NativeMethods.FlashWindow(MainForm.Handle, true);
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
                else if (type == typeof(SuggestionResponse))
                {
                    HandleSuggestionResponse((SuggestionResponse)packet);
                }
                else if (type == typeof(PrivateMessage))
                {
                    GetForm<frmPrivate>().AddPrivateMessage((PrivateMessage)packet);
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

        private static T GetForm<T>() where T : Form
        {
            foreach (Form form in Application.OpenForms)
                if (form is T)
                    return (T)form;

            return null;
        }


        private static void HandleSuggestionResponse(SuggestionResponse packet)
        {
            if (packet.Successful)
            {
                MessageBox.Show("Thank you for your suggestion!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There was an error submitting your suggestion.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}