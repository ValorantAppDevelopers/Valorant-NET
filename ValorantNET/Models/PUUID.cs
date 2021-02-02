using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantNET.Models
{
    public class PUUID
    {
        public string status { get; set; }
        public Data data { get; set; }
        
        public class Data
        {
            public string puuid { get; set; }
        }
    }
}
