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
    public class LoginResponse : IPacket
    {
        [ProtoMember(1)]
        public bool Successful { get; private set; }

        [ProtoMember(2)]
        public string Message { get; private set; }

        public LoginResponse() { }

        public LoginResponse(bool successful)
        {
            Successful = successful;
            Message = null;
        }

        public LoginResponse(bool successful, string message)
        {
            Successful = successful;
            Message = message;
        }

        public void Execute(Client client)
        {
            client.Send<LoginResponse>(this);
        }
    }
}
