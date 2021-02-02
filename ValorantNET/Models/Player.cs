using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantNET.Models
{
    public class Player
    {
        public string user { get; set; }
        public string status { get; set; }
        public Stats stats { get; set; }
        
        public class Stats
        {
            public string rank { get; set; }
            public Playtime playtime { get; set; }
            public int matches { get; set; }
            public int kills { get; set; }
            public int deaths { get; set; }
            public int assists { get; set; }
            public float kdratio { get; set; }
            public int headshots { get; set; }
            public float headshotpercentage { get; set; }
            public int wins { get; set; }
            public float winpercentage { get; set; }
            public int firstbloods { get; set; }
            public int aces { get; set; }
            public int clutches { get; set; }
            public int flawless { get; set; }
            public string playercard { get; set; }
        }

        public class Playtime
        {
            public string playtimepatched { get; set; }
            public int playtimedays { get; set; }
            public int playtimehours { get; set; }
            public int playtimeminutes { get; set; }
            public int playtimeseconds { get; set; }
        }

    }
}
