using Auxilium.Core;
using Auxilium.Core.Packets;
using Auxilium.Core.Packets.ClientPackets;
using Auxilium.Core.Packets.ServerPackets;
using Auxilium.Forms;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Auxilium
{
    internal static class Program
    {
        private static Client Client { get; set; }

        private static frmMain MainForm { get; set; }

        private static frmLogin LoginForm { get; set; }

        [STAThread]
        private static void Main()
        {
            Connect();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm = new frmLogin(Client);
            LoginForm.Show();
            Application.Run();
        }

        private static void Connect()
        {
            if (Client == null || !Client.Connected)
                Client = new Client(8192);

            Client.AddTypesToSerializer(typeof(IPacket), new Type[]
            {
                typeof(Initialize),
                typeof(Login), typeof(LoginResponse),
                typeof(Register), typeof(RegisterResponse),
                typeof(ClientMessage), typeof(BroadcastMessage)
            });

            Client.ClientState += ClientState;
            Client.ClientRead += ClientRead;
            Client.ClientFail += ClientFail;

            Client.Connect("127.0.0.1", 35);
        }

        private static void ClientState(Client client, bool connected)
        {
            if (connected)
            {
                Console.WriteLine("Connected!");
            }
            else
            {
                Console.WriteLine("Nop");
            }
        }

        private static void ClientFail(Client client)
        {
        }

        private static void ClientRead(Client client, IPacket packet)
        {
            Type type = packet.GetType();

            if (type == typeof(Initialize))
            {
                client.HashAlgorithm = HashAlgorithm.Create(((Initialize)packet).HashAlgorithm);
            }
            else if (type == typeof(LoginResponse))
            {
                GetForm<frmLogin>().HandleLoginResponse((LoginResponse)packet);
            }
            else if (type == typeof(RegisterResponse))
            {
                GetForm<frmLogin>().HandleRegisterResponse((RegisterResponse)packet);
            }
        }

        private static T GetForm<T>()
        {
            return Application.OpenForms.OfType<T>().FirstOrDefault();
        }
    }
}