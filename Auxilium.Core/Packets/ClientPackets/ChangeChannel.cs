using ProtoBuf;

namespace Auxilium.Core.Packets.ClientPackets
{
    [ProtoContract]
    public class ChangeChannel : IPacket
    {
        [ProtoMember(1)]
        public byte ID { get; set; }

        public ChangeChannel()
        {
        }

        public ChangeChannel(byte id)
        {
            this.ID = id;
        }

        public void Execute(Client client)
        {
            client.Send<ChangeChannel>(this);
        }
    }
}