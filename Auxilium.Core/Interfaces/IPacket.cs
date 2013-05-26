using ProtoBuf;
using System;

namespace Auxilium.Core.Interfaces
{
    [ProtoContract]
    public interface IPacket 
    {
        void Execute(Client client);
    }
}
