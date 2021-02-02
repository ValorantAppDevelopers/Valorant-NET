using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantNET.Models
{
    public class Match
    {
        public string user { get; set; }
        public string status { get; set; }
        public MatchInfo[] matches { get; set; }

        public class MatchInfo
        {
            public bool isAvailable { get; set; }
            public Metadata metadata { get; set; }
            public Game game { get; set; }
        }

        public class Metadata
        {
            public string gameid { get; set; }
            public string modename { get; set; }
            public bool playerhaswon { get; set; }
            public DateTime timestamp { get; set; }
            public string map { get; set; }
            public string agentplayed { get; set; }
        }

        public class Game
        {
            public int roundsplayed { get; set; }
            public int roundswon { get; set; }
            public int roundslost { get; set; }
            public Kda kda { get; set; }
            public int headshots { get; set; }
            public string headshotspercentage { get; set; }
            public int damagemade { get; set; }
            public int damagereceived { get; set; }
            public int econrating { get; set; }
            public Playtime playtime { get; set; }
        }

        public class Kda
        {
            public string kda { get; set; }
            public string kd { get; set; }
            public int kills { get; set; }
            public int deaths { get; set; }
            public int assists { get; set; }
        }

        public class Playtime
        {
            public int value { get; set; }
            public string patched { get; set; }
        }

    }
}
