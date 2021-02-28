using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantNET.Models
{
    public class Player : BaseResponse
    {
        public string user { get; set; }
        public Stats stats { get; set; }
        public List<Agent> agents { get; set; }
        public List<Map> maps { get; set; }

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

        public class Agent
        {
            public string agent { get; set; }
            public string agenturl { get; set; }
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
        }

        public class Map
        {
            public string map { get; set; }
            public string mapurl { get; set; }
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
