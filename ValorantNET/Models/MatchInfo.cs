using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantNET.Models
{
    public class MatchInfo
    {
        public Metadata metadata { get; set; }
        public Data data { get; set; }

        public class Metadata
        {
            public string gameid { get; set; }
            public string modeimage { get; set; }
            public string modename { get; set; }
            public int duration { get; set; }
            public DateTime timestamp { get; set; }
            public string map { get; set; }
            public int rounds { get; set; }
        }

        public class Data
        {
            public Teams teams { get; set; }
            public Player player { get; set; }
        }

        public class Teams
        {
            public Blue blue { get; set; }
            public Red red { get; set; }
        }

        public class Blue
        {
            public bool haswon { get; set; }
            public int roundswon { get; set; }
            public int teamkills { get; set; }
            public int teamdeaths { get; set; }
            public int teamassists { get; set; }
            public int teamdamage { get; set; }
        }

        public class Red
        {
            public bool haswon { get; set; }
            public int roundswon { get; set; }
            public int teamkills { get; set; }
            public int teamdeaths { get; set; }
            public int teamassists { get; set; }
            public int teamdamage { get; set; }
        }

        public class Player
        {
            public Byteam byteam { get; set; }
            public Unsorted[] unsorted { get; set; }
        }

        public class Byteam
        {
            public Blue1[] blue { get; set; }
            public Red1[] red { get; set; }
        }

        public class Blue1
        {
            public string user { get; set; }
            public string agentused { get; set; }
            public string rank { get; set; }
            public string rankimage { get; set; }
            public string scoreaverage { get; set; }
            public string killsperround { get; set; }
            public Kda kda { get; set; }
            public int damage { get; set; }
            public string damageperround { get; set; }
            public Multiplekills multiplekills { get; set; }
        }

        public class Kda
        {
            public string kda { get; set; }
            public string kdratio { get; set; }
            public int kills { get; set; }
            public int deaths { get; set; }
            public int assists { get; set; }
        }

        public class Multiplekills
        {
            public int triple { get; set; }
            public int quadra { get; set; }
            public int penta { get; set; }
        }

        public class Red1
        {
            public string user { get; set; }
            public string agentused { get; set; }
            public string rank { get; set; }
            public string rankimage { get; set; }
            public string scoreaverage { get; set; }
            public string killsperround { get; set; }
            public Kda1 kda { get; set; }
            public int damage { get; set; }
            public string damageperround { get; set; }
            public Multiplekills1 multiplekills { get; set; }
        }

        public class Kda1
        {
            public string kda { get; set; }
            public string kdratio { get; set; }
            public int kills { get; set; }
            public int deaths { get; set; }
            public int assists { get; set; }
        }

        public class Multiplekills1
        {
            public int triple { get; set; }
            public int quadra { get; set; }
            public int penta { get; set; }
        }

        public class Unsorted
        {
            public string user { get; set; }
            public string agentused { get; set; }
            public string rank { get; set; }
            public string rankimage { get; set; }
            public string scoreaverage { get; set; }
            public string killsperround { get; set; }
            public Kda2 kda { get; set; }
            public int damage { get; set; }
            public string damageperround { get; set; }
            public Multiplekills2 multiplekills { get; set; }
        }

        public class Kda2
        {
            public string kda { get; set; }
            public string kdratio { get; set; }
            public int kills { get; set; }
            public int deaths { get; set; }
            public int assists { get; set; }
        }

        public class Multiplekills2
        {
            public int triple { get; set; }
            public int quadra { get; set; }
            public int penta { get; set; }
        }
    }
}
