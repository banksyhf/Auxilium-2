using ProtoBuf;

namespace Auxilium.Core.Packets
{
    [ProtoContract]
    public interface IPacket
    {
        void Execute(Client client);
    }
}