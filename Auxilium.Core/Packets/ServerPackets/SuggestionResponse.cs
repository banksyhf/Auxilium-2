using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;

namespace Auxilium.Core.Packets.ServerPackets
{
    [ProtoContract]
    public class SuggestionResponse : IPacket
    {
        [ProtoMember(1)]
        public bool Successful { get; set; }

        public SuggestionResponse() { }
        public SuggestionResponse(bool successful) 
        {
            this.Successful = successful;
        }

        public void Execute(Client client)
        {
            client.Send<SuggestionResponse>(this);
        }

    }
}
