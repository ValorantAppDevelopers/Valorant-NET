using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantNET.Models
{
    public class Account : BaseResponse
    {
        public Data data { get; set; }

        public class Data
        {
            public string puuid { get; set; }
            public string region { get; set; }
            public string account_level { get; set; }
        }
    }
}
