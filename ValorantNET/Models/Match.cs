using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantNET.Models
{
    public class Match : BaseResponse
    {
        public Data[] data { get; set; }

        public class Data
        {
            public Metadata metadata { get; set; }
            public PlayerData players { get; set; }
        }

        public class Metadata
        {
            public string map { get; set; }
            public string game_version { get; set; }
            public string game_length { get; set; }
            public string game_start { get; set; }
            public string game_start_patched { get; set; }
            public string rounds_played { get; set; }
            public string mode { get; set; }
            public string mode_id { get; set; }
            public string queue { get; set; }
            public string season_id { get; set; }
            public string platform { get; set; }
            public string matchid { get; set; }
            public PremierInfo premier_info { get; set; }
            public string region { get; set; }
            public string cluster { get; set; }
        }
        public class PremierInfo
        {
            public string tournament_id { get; set; }
            public string matchup_id { get; set; }
        }
        public class PlayerData
        {
            public Players[] all_players { get; set; }
        }
        public class Players
        {
            public string puuid { get; set; }
            public string name { get; set; }
            public string tag { get; set; }
            public string team { get; set; }
            public string level { get; set; }
            public string character { get; set; }
            public string currenttier { get; set; }
            public string currenttier_patched { get; set; }
            public string player_card { get; set; }
            public string player_title { get; set; }
            public string party_id { get; set; }
            public SessionPlaytime session_playtime { get; set; }
            public Assets assets { get; set; }
            public Behavior behaviour { get; set; }
            public AbilityCasts ability_casts { get; set; }
            public Stats stats { get; set; }
        }
        public class SessionPlaytime
        {
            public string minutes { get; set; }
            public string seconds { get; set; }
            public string milliseconds { get; set; }
        }
        public class Assets
        {
            public Card card { get; set; }
            public Agent agent { get; set; }
        }
        public class Card
        {
            public string small { get; set; }
            public string large { get; set; }
            public string wide { get; set; }
        }
        public class Agent
        {
            public string small { get; set; }
            public string full { get; set; }
            public string bust { get; set; }
            public string killfeed { get; set; }
        }
        public class Behavior
        {
            public string afk_rounds { get; set; }
            public FriendlyFireData friendly_fire { get; set; }
            public string rounds_in_spawn { get; set; }
        }
        public class FriendlyFireData
        {
            public string incoming { get; set; }
            public string outgoing { get; set; }
        }
        public class AbilityCasts
        {
            public string c_cast { get; set; }
            public string q_cast { get; set; }
            public string e_cast { get; set; }
            public string x_cast { get; set; }
        }
        public class Stats
        {
            public string score { get; set; }
            public string kills { get; set; }
            public string deaths { get; set; }
            public string assists { get; set; }
            public string bodyshots { get; set; }
            public string headshots { get; set; }
            public string legshots { get; set; }
        }
    }
}