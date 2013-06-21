using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;

namespace Auxilium.Core.Packets.ClientPackets
{
    [ProtoContract]
    public class Suggestion : IPacket
    {
        [ProtoMember(1)]
        public string Text { get; set; }

        [ProtoMember(2)]
        public string Username { get; set; }

        public Suggestion() { }
        public Suggestion(string username, string text)
        {
            this.Username = username;
            this.Text = text;
        }

        public void Execute(Client client)
        {
            client.Send<Suggestion>(this);
        }
    }
}
