using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantNET.Models
{
    public class Leaderboard : BaseResponse
    {
        public List<Data> data { get; set; }
        
        public class Data
        {
            public string Subject { get; set; }
            public string GameName { get; set; }
            public string TagLine { get; set; }
            public int LeaderboardRank { get; set; }
            public int RankedRating { get; set; }
            public int NumberOfWins { get; set; }
            public string PlayerCardID { get; set; }
            public string TitleID { get; set; }
            public bool IsBanned { get; set; }
            public bool IsAnonymized { get; set; }
        }

    }
}
