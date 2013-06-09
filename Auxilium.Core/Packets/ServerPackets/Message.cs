using ProtoBuf;

namespace Auxilium.Core.Packets.ServerPackets
{
    [ProtoContract]
    public class BroadcastMessage : IPacket
    {
        [ProtoMember(1)]
        public string MessageText { get; private set; }

        [ProtoMember(2)]
        public string Username { get; private set; }

        public void Execute(Client client)
        {
            client.Send<BroadcastMessage>(this);
        }
    }
}