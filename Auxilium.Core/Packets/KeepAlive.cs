using System;
using ProtoBuf;

namespace Auxilium.Core.Packets
{
    [ProtoContract]
    internal class KeepAlive : IPacket, IDisposable
    {
        [ProtoMember(1)]
        public DateTime TimeSent { get; private set; }

        public Client Client;

        public void Execute(Client client)
        {
            TimeSent = DateTime.Now;
            Client = client;
            client.Send<KeepAlive>(this);
        }

        public void Dispose()
        {
            TimeSent = default(DateTime);
        }
    }
}