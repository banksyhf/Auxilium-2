using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Auxilium.Core;
using Auxilium.Core.Interfaces;
using Auxilium.Core.Packets.ClientPackets;
using Auxilium.Core.Packets.ServerPackets;
using System.Windows.Forms;

namespace Auxilium_Server
{
    class Program
    {
        static Server Server { get; set; }

        static void Main(string[] args)
        {

            Server = new Server()
            {
                BufferSize = 8192,
                MaxConnections = 500
            };

            Server.ClientRead += ClientRead;
            Server.ClientState += ClientState;

            Server.Listen(35);

            Application.Run();
        }

        static void ClientState(Server s, Client c, bool connected)
        {
            if (connected)
            {
                c.Value = new UserState();
            }
            else
            {
                HandleClientDisconnected(c);
            }
        }

        static void ClientRead(Server s, Client c, IPacket packet)
        {
            Type packetType = packet.GetType();

            if (c.Value.Authenticated)
            {

            }
            else
            {
                if (packetType == typeof(Register))
                {
                }
                else if (packetType == typeof(Login))
                {
                    new LoginResponse(true).Execute(c);
                }
                else if (packetType == typeof(ClientMessage))
                {

                }

            }
        }

        #region " Packet Handlers "

        static void HandleLoginPacket(Client client, Login packet)
        {

            

        }

        #endregion

        static void HandleClientDisconnected(Client client)
        {

        }
    }
}
