using ProtoBuf;

namespace Auxilium.Core.Packets.ServerPackets
{
    [ProtoContract]
    [ProtoInclude(1, typeof(IPacket))]
    public class LoginResponse : IPacket
    {
        [ProtoMember(1)]
        public bool Successful { get; private set; }

        [ProtoMember(2)]
        public string Message { get; private set; }

        [ProtoMember(3)]
        public int ErrorCode { get; set; }

        public LoginResponse()
        {
        }

        public LoginResponse(bool successful, string message, int errorCode)
        {
            Successful = successful;
            Message = message;
            ErrorCode = errorCode;
        }

        public void Execute(Client client)
        {
            client.Send<LoginResponse>(this);
        }
    }
}