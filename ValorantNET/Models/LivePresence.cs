using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantNET.Models
{
    public class LivePresence : BaseResponse
    {
        public Data data { get; set; }

        public class Data
        {
            public string current_selected_gamemode { get; set; }
            public string current_state { get; set; }
            public string party_accessibility { get; set; }
            public string client_version { get; set; }
            public int party_size { get; set; }
            public string party_id { get; set; }
        }
    }
}
