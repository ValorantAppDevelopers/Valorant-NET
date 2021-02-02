using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantNET.Models
{
    public class StoreFeatured
    {
        public string status { get; set; }
        public Data data { get; set; }

        public class Data
        {
            public Featuredbundle FeaturedBundle { get; set; }
        }

        public class Featuredbundle
        {
            public Bundle Bundle { get; set; }
            public int BundleRemainingDurationInSeconds { get; set; }
        }

        public class Bundle
        {
            public string ID { get; set; }
            public string DataAssetID { get; set; }
            public string CurrencyID { get; set; }
            public ItemInfo[] Items { get; set; }
        }

        public class ItemInfo
        {
            public ItemDetail Item { get; set; }
            public int BasePrice { get; set; }
            public string CurrencyID { get; set; }
            public float DiscountPercent { get; set; }
            public bool IsPromoItem { get; set; }
        }

        public class ItemDetail
        {
            public string ItemTypeID { get; set; }
            public string ItemID { get; set; }
            public int Amount { get; set; }
        }
    }
}
