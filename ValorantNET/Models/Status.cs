using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantNET.Models
{
    public class Status
    {
        public string status { get; set; }
        public string region { get; set; }
        public Data data { get; set; }

        public class Data
        {
            public object[] maintenances { get; set; }
            public object[] incidents { get; set; }
        }
    }
}
