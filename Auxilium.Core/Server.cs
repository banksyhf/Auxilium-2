using Auxilium.Core.Interfaces;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Auxilium.Core
{
    public class Server
    {
        public event ServerStateEventHandler ServerState;
        public delegate void ServerStateEventHandler(Server s, bool listening);

        private void OnServerState(bool listening)
        {
            if (ServerState != null)
            {
                ServerState(this, listening);
            }
        }

        public event ClientStateEventHandler ClientState;
        public delegate void ClientStateEventHandler(Server s, Client c, bool connected);

        private void OnClientState(Client c, bool connected)
        {
            if (ClientState != null)
            {
                ClientState(this, c, connected);
            }
        }

        public event ClientReadEventHandler ClientRead;
        public delegate void ClientReadEventHandler(Server s, Client c, IPacket packet);

        private void OnClientRead(Client c, IPacket packet)
        {
            if (ClientRead != null)
            {
                ClientRead(this, c, packet);
            }
        }

        public event ClientWriteEventHandler ClientWrite;
        public delegate void ClientWriteEventHandler(Server s, Client c);

        private void OnClientWrite(Client c)
        {
            if (ClientWrite != null)
            {
                ClientWrite(this, c);
            }
        }


        private Socket _handle;
        private SocketAsyncEventArgs _item;

        private bool Processing { get; set; }
        public int BufferSize { get; set; }
        public ushort MaxConnections { get; set; }

        public bool Listening { get; private set; }

        private List<Client> _clients;
        public Client[] Clients
        {
            get
            {
                return Listening ? _clients.ToArray() : new Client[0];
            }
        }

        public void Listen(ushort port)
        {
            try
            {
                if (!Listening)
                {
                    _clients = new List<Client>();

                    _item = new SocketAsyncEventArgs();
                    _item.Completed += Process;

                    _handle = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                    //_handle.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);

                    _handle.Bind(new IPEndPoint(IPAddress.Any, port));
                    _handle.Listen(10);

                    Processing = false;
                    Listening = true;

                    OnServerState(true);
                    if (!_handle.AcceptAsync(_item))
                        Process(null, _item);
                }
            }
            catch
            {
                Disconnect();
            }
        }

        private void Process(object s, SocketAsyncEventArgs e)
        {
            try
            {
                if (e.SocketError == SocketError.Success)
                {
                    Client T = new Client(e.AcceptSocket, BufferSize);

                    lock (_clients)
                    {
                        if (_clients.Count <= MaxConnections)
                        {
                            _clients.Add(T);
                            T.ClientState += HandleState;
                            T.ClientRead += OnClientRead;
                            T.ClientWrite += OnClientWrite;

                            OnClientState(T, true);
                        }
                        else
                        {
                            T.Disconnect();
                        }
                    }

                    e.AcceptSocket = null;
                    if (!_handle.AcceptAsync(e))
                        Process(null, e);
                }
                else
                {
                    Disconnect();
                }

            }
            catch
            {
                Disconnect();
            }
        }

        public void Disconnect()
        {
            if (Processing)
                return;

            Processing = true;

            if (_handle != null)
                _handle.Close();

            lock (_clients)
            {
                while (_clients.Count != 0)
                {
                    _clients[0].Disconnect();
                    _clients.RemoveAt(0);
                }
            }

            Listening = false;
            OnServerState(false);
        }

        private void HandleState(Client s, bool open)
        {
            lock (_clients)
            {
                _clients.Remove(s);
                OnClientState(s, false);
            }
        }

    }
}
