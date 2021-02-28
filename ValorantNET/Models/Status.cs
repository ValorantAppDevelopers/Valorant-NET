using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantNET.Models
{
    public class Status : BaseResponse
    {
        public string region { get; set; }
        public Data data { get; set; }

        public class Data
        {
            public List<object> maintenances { get; set; }
            public List<object> incidents { get; set; }
        }
    }
}
