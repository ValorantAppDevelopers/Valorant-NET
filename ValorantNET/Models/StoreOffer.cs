using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantNET.Models
{
    public class StoreOffer
    {
        public string status { get; set; }
        public Data data { get; set; }

        public class Data
        {
            public Offer[] Offers { get; set; }
            public Upgradecurrencyoffer[] UpgradeCurrencyOffers { get; set; }
        }

        public class Offer
        {
            public string OfferID { get; set; }
            public bool IsDirectPurchase { get; set; }
            public object StartDate { get; set; }
            public Cost Cost { get; set; }
            public Reward[] Rewards { get; set; }
        }

        public class Cost
        {
            public int _85ad13f73d1b51289eb27cd8ee0b5741 { get; set; }
        }

        public class Reward
        {
            public string ItemTypeID { get; set; }
            public string ItemID { get; set; }
            public int Quantity { get; set; }
        }

        public class Upgradecurrencyoffer
        {
            public string OfferID { get; set; }
            public string StorefrontItemID { get; set; }
        }
    }
}
