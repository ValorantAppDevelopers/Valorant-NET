using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantNET.Models
{
    public class MMR : BaseResponse
    {
        public class Data
        {
            public Current_Data current_data { get; set; }
            public By_Season by_season { get; set; }
        }

        public class Current_Data
        {
            public int currenttier { get; set; }
            public string currenttierpatched { get; set; }
            public int ranking_in_tier { get; set; }
            public int mmr_change_to_last_game { get; set; }
            public int elo { get; set; }
            public int games_needed_for_rating { get; set; }
        }

        public class By_Season
        {
            public E2a1 e2a1 { get; set; }
            public E1a3 e1a3 { get; set; }
            public E1a2 e1a2 { get; set; }
            public E1a1 e1a1 { get; set; }
        }

        public class Act_Rank_Wins
        {
            public string patched_tier { get; set; }
            public int tier { get; set; }
        }

        public class E2a1
        {
            public int wins { get; set; }
            public int number_of_games { get; set; }
            public int final_rank { get; set; }
            public string final_rank_patched { get; set; }
            public List<Act_Rank_Wins> act_rank_wins { get; set; }
        }

        public class E1a3
        {
            public int wins { get; set; }
            public int number_of_games { get; set; }
            public int final_rank { get; set; }
            public string final_rank_patched { get; set; }
            public List<Act_Rank_Wins> act_rank_wins { get; set; }
        }

        public class E1a2
        {
            public int wins { get; set; }
            public int number_of_games { get; set; }
            public int final_rank { get; set; }
            public string final_rank_patched { get; set; }
            public List<Act_Rank_Wins> act_rank_wins { get; set; }
        }

        public class E1a1
        {
            public int wins { get; set; }
            public int number_of_games { get; set; }
            public int final_rank { get; set; }
            public string final_rank_patched { get; set; }
            public List<Act_Rank_Wins> act_rank_wins { get; set; }
        }
    }
}
