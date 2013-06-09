﻿using ProtoBuf;
using System;

namespace Auxilium.Core.Packets
{
    [ProtoContract]
    internal class KeepAlive : IPacket
    {
        [ProtoMember(1)]
        public DateTime TimeSent { get; private set; }

        public Client Client;

        public void Execute(Client client)
        {
            TimeSent = DateTime.Now;
            Client = client;
            client.Send<KeepAlive>(this);
        }
    }
}