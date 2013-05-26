using Auxilium.Core.Interfaces;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Auxilium.Core.Packets.ClientPackets
{
    [ProtoContract]
    [ProtoInclude(1, typeof(IPacket))]
    public class Register : IPacket
    {
        [ProtoMember(1)]
        public string Username { get; private set; }

        [ProtoMember(2)]
        public string Password { get; private set; }

        [ProtoMember(3)]
        public string Email { get; private set; }

        public Register() { }

        public Register(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }

        public void Execute(Client client)
        {
            client.Send<Register>(this);
        }
    }
}
