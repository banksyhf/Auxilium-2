using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Auxilium.Core;
using Auxilium.Core.Interfaces;
using Auxilium.Forms;
using Auxilium.Core.Packets.ServerPackets;

namespace Auxilium
{
    static class Program
    {

        static Client Client { get; set; }

        static frmMain MainForm { get; set; }

        static frmLogin LoginForm { get; set; }

        [STAThread]
        static void Main()
        {
            Connect();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm = new frmLogin(Client);
            LoginForm.Show();
            Application.Run();
        }

        static void Connect()
        {
            if (Client == null || !Client.Connected)
                Client = new Client() { BufferSize = 8192 };

            Client.ClientState += new Core.Client.ClientStateEventHandler(ClientState);
            Client.ClientRead += new Core.Client.ClientReadEventHandler(ClientRead);
            Client.ClientFail += new Core.Client.ClientFailEventHandler(ClientFail);

            Client.Connect("127.0.0.1", 35);
        }
        
        static void ClientState(Client s, bool connected)
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

        static void ClientFail(Client s)
        {

        }

        static void ClientRead(Client s, IPacket packet)
        {

            Type type = packet.GetType();

            if (type == typeof(LoginResponse))
            {
                GetForm<frmLogin>().HandleLoginResponse((LoginResponse)packet);
            }
            else if (type == typeof(RegisterResponse))
            {
                GetForm<frmLogin>().HandleRegisterResponse((RegisterResponse)packet);
            }

        }

        static T GetForm<T>()
        {
            return Application.OpenForms.OfType<T>().FirstOrDefault();
        }
    }
}
