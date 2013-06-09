using ProtoBuf;

namespace Auxilium.Core.Packets.ServerPackets
{
    [ProtoContract]
    public class Initialize : IPacket
    {
        [ProtoMember(1)]
        public string HashAlgorithm { get; private set; }

        public Initialize()
        {
        }

        public Initialize(string hashAlgorithm)
        {
            this.HashAlgorithm = hashAlgorithm;
        }

        public void Execute(Client client)
        {
            client.Send<Initialize>(this);
        }
    }
}