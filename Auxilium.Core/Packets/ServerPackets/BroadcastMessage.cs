using System;
using ProtoBuf;

namespace Auxilium.Core.Packets.ServerPackets
{
    [ProtoContract]
    public class BroadcastMessage : IPacket, IDisposable
    {
        [ProtoMember(1)]
        public string Text { get; private set; }

        [ProtoMember(2)]
        public string Username { get; private set; }

        [ProtoMember(3)]
        public int ID { get; private set; }

        [ProtoMember(4)]
        public DateTime Time { get; set; }

        public BroadcastMessage()
        {
        }

        public BroadcastMessage(string message, string username, int id)
        {
            this.Text = message;
            this.Username = username;
            this.ID = id;
            this.Time = DateTime.Now.ToUniversalTime();
        }

        public void Execute(Client client)
        {
            client.Send<BroadcastMessage>(this);
        }

        public void Dispose()
        {
            this.Text = null;
            this.Username = null;
        }
    }
}