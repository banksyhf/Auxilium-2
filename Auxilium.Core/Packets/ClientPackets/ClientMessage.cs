using ProtoBuf;

namespace Auxilium.Core.Packets.ClientPackets
{
    [ProtoContract]
    [ProtoInclude(1, typeof(IPacket))]
    public class ClientMessage : IPacket
    {
        [ProtoMember(1)]
        public string Message { get; private set; }

        public ClientMessage()
        {
        }

        public ClientMessage(string message)
        {
            Message = message;
        }

        public void Execute(Client client)
        {
            client.Send<ClientMessage>(this);
        }
    }
}