using LZ4;
using Auxilium.Core.Interfaces;
using Auxilium.Core.Packets;
using Auxilium.Core.Packets.ClientPackets;
using Auxilium.Core.Packets.ServerPackets;
using ProtoBuf;
using ProtoBuf.Meta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;

namespace Auxilium.Core
{
    public class Client
    {
        //TODO: Lock objects where needed.
        //TODO: Raise Client_Fail with exception.
        //TODO: Create and handle ReadQueue.

        public event ClientFailEventHandler ClientFail;
        public delegate void ClientFailEventHandler(Client s);

        private void OnClientFail()
        {
            if (ClientFail != null)
            {
                ClientFail(this);
            }
        }

        public event ClientStateEventHandler ClientState;
        public delegate void ClientStateEventHandler(Client s, bool connected);

        private void OnClientState(bool connected)
        {
            if (ClientState != null)
            {
                ClientState(this, connected);
            }
        }

        public event ClientReadEventHandler ClientRead;
        public delegate void ClientReadEventHandler(Client s, IPacket packet);

        private void OnClientRead(byte[] e)
        {
            if (ClientRead != null)
            {
                e = Decompressor.Decompress(e);

                using (MemoryStream deserialized = new MemoryStream(e))
                {
                    IPacket packet = Serializer.Deserialize<IPacket>(deserialized);
                    ClientRead(this, packet);
                }
            }
        }

        public event ClientWriteEventHandler ClientWrite;
        public delegate void ClientWriteEventHandler(Client s);

        private void OnClientWrite()
        {
            if (ClientWrite != null)
            {
                ClientWrite(this);
            }
        }

        private readonly AsyncOperation _asyncOperation;
        private Socket _handle;

        private int _sendIndex;
        private byte[] _sendBuffer;

        private int _readIndex;
        private byte[] _readBuffer;

        private Queue<byte[]> _sendQueue;

        private readonly SocketAsyncEventArgs[] _items = new SocketAsyncEventArgs[2];

        private bool[] _processing = new bool[2];

        public int BufferSize { get; set; }
        public UserState Value { get; set; }

        private IPEndPoint _endPoint;
        public IPEndPoint EndPoint
        {
            get
            {
                return _endPoint ?? new IPEndPoint(IPAddress.None, 0);
            }
        }

        public bool Connected { get; private set; }

        private LZ4Compressor32 Compressor { get; set; }
        private LZ4Decompressor32 Decompressor { get; set; }

        public Client()
        {
            _asyncOperation = AsyncOperationManager.CreateOperation(null);

        }

        public Client(Socket sock, int size)
        {
            try
            {
                _asyncOperation = AsyncOperationManager.CreateOperation(null);
                
                Initialize();
                _items[0].SetBuffer(new byte[size], 0, size);

                _handle = sock;

                _handle.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
                _handle.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.NoDelay, true);
                _handle.NoDelay = true;

                BufferSize = size;
                _endPoint = (IPEndPoint)_handle.RemoteEndPoint;
                Connected = true;

                if (!_handle.ReceiveAsync(_items[0]))
                    Process(null, _items[0]);
            }
            catch
            {
                Disconnect();
            }
        }

        public void Connect(string host, ushort port)
        {
            try
            {
                Disconnect();
                Initialize();

                _handle = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                _handle.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
                _handle.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.NoDelay, true);
                _handle.NoDelay = true;

                _items[0].RemoteEndPoint = new IPEndPoint(IPAddress.Parse(host), port);
                if (!_handle.ConnectAsync(_items[0]))
                    Process(null, _items[0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                OnClientFail();
                Disconnect();
            }
        }


        private void Initialize()
        {
            Compressor = new LZ4Compressor32();
            Decompressor = new LZ4Decompressor32();

            Type[] packetTypes = Utils.GetTypesInNamespace("Packets");
            for (int i = 1; i <= packetTypes.Length; i++)
            {
                RuntimeTypeModel.Default[typeof(IPacket)].AddSubType(i, packetTypes[i - 1]);
            }

            _processing = new bool[2];

            _sendIndex = 0;
            _readIndex = 0;

            _sendBuffer = new byte[0];
            _readBuffer = new byte[0];

            _sendQueue = new Queue<byte[]>();

            _items[0] = new SocketAsyncEventArgs();
            _items[1] = new SocketAsyncEventArgs();
            _items[0].Completed += Process;
            _items[1].Completed += Process;
        }

        private void Process(object s, SocketAsyncEventArgs e)
        {
            try
            {
                if (e.SocketError == SocketError.Success)
                {
                    switch (e.LastOperation)
                    {
                        case SocketAsyncOperation.Connect:
                            _endPoint = (IPEndPoint)_handle.RemoteEndPoint;
                            Connected = true;
                            _items[0].SetBuffer(new byte[BufferSize], 0, BufferSize);

                            _asyncOperation.Post(x => OnClientState((bool)x), true);
                            if (!_handle.ReceiveAsync(e))
                                Process(null, e);
                            break;
                        case SocketAsyncOperation.Receive:
                            if (!Connected)
                                return;

                            if (e.BytesTransferred != 0)
                            {
                                HandleRead(e.Buffer, 0, e.BytesTransferred);

                                if (!_handle.ReceiveAsync(e))
                                    Process(null, e);
                            }
                            else
                            {
                                Disconnect();
                            }
                            break;
                        case SocketAsyncOperation.Send:
                            if (!Connected)
                                return;

                            _asyncOperation.Post(x => OnClientWrite(), null);
                            _sendIndex += e.BytesTransferred;

                            bool eos = (_sendIndex >= _sendBuffer.Length);

                            if (_sendQueue.Count == 0 && eos)
                                _processing[1] = false;
                            else
                                HandleSendQueue();
                            break;
                    }
                }
                else
                {
                    if (e.LastOperation == SocketAsyncOperation.Connect)
                        _asyncOperation.Post(x => OnClientFail(), null);
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
            if (_processing[0])
                return;

            _processing[0] = true;

            bool raise = Connected;
            Connected = false;

            if (_handle != null)
                _handle.Close();
            if (_sendQueue != null)
                _sendQueue.Clear();

            _sendBuffer = new byte[0];
            _readBuffer = new byte[0];

            if (raise)
                _asyncOperation.Post(x => OnClientState(false), null);

            Value = null;
            _endPoint = null;
        }

        //public void SendHeader(byte header)
        //{
        //    if (!Connected) return;

        //    //byte[] data = Serializer.Serialize(header);

        //    //Send(data);
        //}

        public void Send<T>(IPacket packet) where T : IPacket
        {
            if (!Connected) return;

            byte[] data = null;

            using (MemoryStream ms = new MemoryStream())
            {
                Serializer.Serialize<T>(ms, (T)packet);
                data = ms.ToArray();
            }
            
            Send(data);
        }


        private void Send(byte[] data)
        {
            data = Compressor.Compress(data);

            _sendQueue.Enqueue(data);

            if (!_processing[1])
            {
                _processing[1] = true;
                HandleSendQueue();
            }
        }


        private void HandleSendQueue()
        {
            try
            {
                if (_sendIndex >= _sendBuffer.Length)
                {
                    _sendIndex = 0;
                    _sendBuffer = Header(_sendQueue.Dequeue());
                }

                int write = Math.Min(_sendBuffer.Length - _sendIndex, BufferSize);
                _items[1].SetBuffer(_sendBuffer, _sendIndex, write);

                if (!_handle.SendAsync(_items[1]))
                    Process(null, _items[1]);
            }
            catch
            {
                Disconnect();
            }
        }

        private byte[] Header(byte[] data)
        {
            byte[] T = new byte[data.Length + 4];
            Buffer.BlockCopy(BitConverter.GetBytes(data.Length), 0, T, 0, 4);
            Buffer.BlockCopy(data, 0, T, 4, data.Length);
            return T;
        }

        private void HandleRead(byte[] data, int index, int length)
        {
            try
            {
                if (_readIndex >= _readBuffer.Length)
                {
                    _readIndex = 0;
                    Array.Resize(ref _readBuffer, BitConverter.ToInt32(data, index));
                    index += 4;
                }

                int read = Math.Min(_readBuffer.Length - _readIndex, length - index);
                Buffer.BlockCopy(data, index, _readBuffer, _readIndex, read);
                _readIndex += read;

                if (_readIndex >= _readBuffer.Length)
                {
                    _asyncOperation.Post(x => OnClientRead((byte[])x), _readBuffer);
                }

                if (read < (length - index))
                {
                    HandleRead(data, index + read, length);
                }
            }
            catch { }
        }

    }
}
