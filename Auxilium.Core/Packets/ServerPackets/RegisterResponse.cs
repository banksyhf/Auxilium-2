using System;
using ProtoBuf;

namespace Auxilium.Core.Packets.ServerPackets
{
    [ProtoContract]
    public class RegisterResponse : IPacket, IDisposable
    {
        [ProtoMember(1)]
        public bool Successful { get; private set; }

        [ProtoMember(2)]
        public string Message { get; private set; }

        [ProtoMember(3)]
        public int ErrorCode { get; set; }

        public RegisterResponse()
        {
        }

        public RegisterResponse(bool successful, string message, int errorCode)
        {
            Successful = successful;
            Message = message;
            ErrorCode = errorCode;
        }

        public void Execute(Client client)
        {
            client.Send<RegisterResponse>(this);
            this.Dispose();
        }

        public void Dispose()
        {
            this.Message = null;
            this.ErrorCode = 0;
        }
    }
}