using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;
using Auxilium.Core.Interfaces;

namespace Auxilium.Core.Packets.ServerPackets
{
    [ProtoContract]
    [ProtoInclude(1, typeof(IPacket))]
    public class Message : IPacket
    {

        [ProtoMember(1)]
        public string MessageText { get; private set; }

        [ProtoMember(2)]
        public string Username { get; private set; }


        public void Execute(Client client)
        {
            client.Send<Message>(this);
        }
    }
}
