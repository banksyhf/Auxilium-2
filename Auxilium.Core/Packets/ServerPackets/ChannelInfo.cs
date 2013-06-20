using ProtoBuf;

namespace Auxilium.Core.Packets.ServerPackets
{
    [ProtoContract]
    public class ChannelList : IPacket
    {
        [ProtoMember(1)]
        public ChannelInfo[] Channels { get; set; }

        [ProtoMember(2)]
        public byte CurrentChannel { get; set; }

        public ChannelList()
        {
        }

        public ChannelList(ChannelInfo[] channels)
        {
            this.Channels = channels;
        }

        public void Execute(Client client)
        {
            client.Send<ChannelList>(this);
        }

        public void Dispose()
        {
            this.Channels = null;
        }
    }

    [ProtoContract]
    public class ChannelInfo
    {
        [ProtoMember(1)]
        public string Name { get; set; }

        [ProtoMember(2)]
        public byte ID { get; set; }

        [ProtoMember(3)]
        public UserInfo[] Users { get; set; }

        public ChannelInfo()
        {
        }

        public ChannelInfo(string name, byte id, UserInfo[] users)
        {
            this.Name = name;
            this.ID = id;
            this.Users = users;
        }
    }

    [ProtoContract]
    public class UserInfo
    {
        [ProtoMember(1)]
        public string Name { get; set; }

        [ProtoMember(2)]
        public byte Rank { get; set; }

        [ProtoMember(3)]
        public int ID { get; set; }

        public UserInfo()
        {
        }

        public UserInfo(string name, byte rank, int id)
        {
            this.Name = name;
            this.Rank = rank;
            this.ID = id;
        }
    }

    public enum SpecialRank : byte
    {
        Admin = 41
    }
}