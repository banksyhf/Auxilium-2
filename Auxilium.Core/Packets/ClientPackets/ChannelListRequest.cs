using ProtoBuf;

namespace Auxilium.Core.Packets.ClientPackets
{
    [ProtoContract]
    public class ChannelListRequest : IPacket
    {
        public void Execute(Client client)
        {
            client.Send<ChannelListRequest>(this);
        }
    }
}