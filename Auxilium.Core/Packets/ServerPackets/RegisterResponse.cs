using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;
using Auxilium.Core.Interfaces;

namespace Auxilium.Core.Packets.ServerPackets
{
    [ProtoContract]
    [ProtoInclude(1, typeof(IPacket))]
    public class RegisterResponse : IPacket
    {
        [ProtoMember(1)]
        public bool Successful { get; private set; }

        [ProtoMember(2)]
        public string Message { get; private set; }

        public RegisterResponse() { }

        public RegisterResponse(bool successful)
        {
            Successful = successful;
            Message = null;
        }

        public RegisterResponse(bool successful, string message)
        {
            Successful = successful;
            Message = message;
        }

        public void Execute(Client client)
        {
            client.Send<RegisterResponse>(this);
        }
    }
}
