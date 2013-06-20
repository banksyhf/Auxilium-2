using System;
using System.Security.Cryptography;
using ProtoBuf;

namespace Auxilium.Core.Packets.ClientPackets
{
    [ProtoContract]
    [ProtoInclude(1, typeof(IPacket))]
    public class Login : IPacket, IDisposable
    {
        [ProtoMember(1)]
        public string Username { get; private set; }

        [ProtoMember(2)]
        public string Password { get; private set; }

        public Login()
        {
        }

        public Login(string username, string password, HashAlgorithm algo)
        {
            Username = username;
            Password = password.Hash(algo);
        }

        public void Execute(Client client)
        {
            client.Send<Login>(this);
            this.Dispose();
        }

        public void Dispose()
        {
            this.Username = null;
            this.Password = null;
        }
    }
}