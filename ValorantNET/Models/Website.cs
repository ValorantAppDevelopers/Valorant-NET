using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantNET.Models
{
    public class Website
    {
        public string status { get; set; }
        public Data[] data { get; set; }

        public class Data
        {
            public string banner_url { get; set; }
            public string category { get; set; }
            public DateTime date { get; set; }
            public string external_link { get; set; }
            public string title { get; set; }
            public string url { get; set; }
        }
    }
}
