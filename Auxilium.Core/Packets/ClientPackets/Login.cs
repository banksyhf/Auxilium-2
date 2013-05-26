using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Auxilium.Core.Interfaces;
using ProtoBuf;

namespace Auxilium.Core.Packets.ClientPackets
{
    [ProtoContract]
    [ProtoInclude(1, typeof(IPacket))]
    public class Login : IPacket
    {
        [ProtoMember(1)]
        public string Username { get; private set; }

        [ProtoMember(2)]
        public string Password { get; private set; }

        public Login() { }

        public Login(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public void Execute(Client client)
        {
            client.Send<Login>(this);
        }
    }
}
