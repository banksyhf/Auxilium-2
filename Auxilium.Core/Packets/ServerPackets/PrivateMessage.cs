using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;

namespace Auxilium.Core.Packets.ServerPackets
{
    [ProtoContract]
    public class PrivateMessage : IPacket
    {
        [ProtoMember(1)]
        public string Subject { get; set; }

        [ProtoMember(2)]
        public string Sender { get; set; }

        [ProtoMember(3)]
        public string Recipient { get; set; }

        [ProtoMember(4)]
        public DateTime TimeSent { get; set; }

        [ProtoMember(5)]
        public string Message { get; set; }

        public PrivateMessage() { }
        public PrivateMessage(string subject, string sender, string recipient, DateTime time, string message)
        {
            this.Subject = subject;
            this.Sender = sender;
            this.Recipient = recipient;
            this.TimeSent = time;
            this.Message = message;
        }

        public void Execute(Client client)
        {
            client.Send<PrivateMessage>(this);
        }
    }
}
