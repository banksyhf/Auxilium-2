using System;
using ProtoBuf;

namespace Auxilium.Core.Packets
{
    [ProtoContract]
    internal class KeepAliveResponse : IPacket, IDisposable
    {
        [ProtoMember(1)]
        public DateTime TimeSent { get; set; }

        public void Execute(Client client)
        {
            client.Send<KeepAliveResponse>(this);
        }

        public void Dispose()
        {
            this.TimeSent = default(DateTime);
        }
    }
}