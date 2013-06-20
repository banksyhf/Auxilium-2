using System;

namespace Auxilium.Core
{
    public class UserState
    {
        public bool Authenticated { get; set; }

        public string Username { get; set; }

        public byte Channel { get; set; }

        public byte Rank { get; set; }

        public int ID { get; set; }

        public int Percentage { get; set; }

        public int ExperienceRequired { get; set; }

        public int Points { get; set; }

        public byte PacketCount { get; set; }

        public DateTime LastPacket { get; set; }

        public bool Idle { get; set; }

        public DateTime LastAction { get; set; }

        public DateTime LastPayout { get; set; }

        public UserState()
        {
            LastAction = DateTime.Now;
            LastPayout = DateTime.Now;
        }

        public void AddPoints(int points)
        {
            Points = Math.Min(Points + points, 2812000);

            if (Rank >= 37)
            {
                Percentage = 100;
                ExperienceRequired = 0;
                return;
            }

            int nextRank = ((Rank / 2) + 1) * (Rank + 1) * 4000;

            int previousRank = (((Rank - 1) / 2) + 1) * Rank * 4000;

            if (Points >= nextRank)
                Rank += 1;

            Percentage = (int)Math.Round((((double)Points - (double)previousRank) / ((double)nextRank - (double)previousRank)) * 100);

            ExperienceRequired = nextRank - Points;
        }

        public bool IsFlooding()
        {
            PacketCount += 1;
            if (PacketCount == 10)
                return true;

            if ((DateTime.Now - LastPacket).TotalSeconds >= 3)
                PacketCount = 0;

            LastPacket = DateTime.Now;
            return false;
        }
    }
}