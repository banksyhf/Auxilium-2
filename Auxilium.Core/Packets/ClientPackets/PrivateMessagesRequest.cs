using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;

namespace Auxilium.Core.Packets.ClientPackets
{
    [ProtoContract]
    public class PrivateMessagesRequest : IPacket
    {
        public void Execute(Client client)
        {
            client.Send<PrivateMessagesRequest>(this);
        }
    }
}
