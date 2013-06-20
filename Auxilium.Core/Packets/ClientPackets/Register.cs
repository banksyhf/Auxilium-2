using System;
using System.Security.Cryptography;
using ProtoBuf;

namespace Auxilium.Core.Packets.ClientPackets
{
    [ProtoContract]
    [ProtoInclude(1, typeof(IPacket))]
    public class Register : IPacket, IDisposable
    {
        [ProtoMember(1)]
        public string Username { get; private set; }

        [ProtoMember(2)]
        public string Password { get; private set; }

        [ProtoMember(3)]
        public string Email { get; private set; }

        public Register()
        {
        }

        public Register(string username, string password, string email, HashAlgorithm algo)
        {
            Username = username;
            Password = password.Hash(algo);
            Email = email;
        }

        public void Execute(Client client)
        {
            client.Send<Register>(this);
            this.Dispose();
        }

        public void Dispose()
        {
            this.Username = null;
            this.Password = null;
            this.Email = null;
        }
    }
}