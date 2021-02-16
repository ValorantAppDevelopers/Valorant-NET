using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantNET.Models
{
    public class MMR
    {
        public string status { get; set; }
        public Data data { get; set; }

        public class Data
        {
            public int currenttier { get; set; }
            public string currenttierpatched { get; set; }
            public int ranking_in_tier { get; set; }
            public int mmr_change_to_last_game { get; set; }
            public int elo { get; set; }
            public string date { get; set; }
            public long date_raw { get; set; }
        }
    }
}
