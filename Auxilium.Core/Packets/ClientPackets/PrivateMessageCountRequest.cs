using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;

namespace Auxilium.Core.Packets.ClientPackets
{
    [ProtoContract]
    public class PrivateMessageCountRequest : IPacket
    {
        public void Execute(Client client)
        {
            client.Send<PrivateMessageCountRequest>(this);
        }
    }
}
