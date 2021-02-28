using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantNET.Models
{
    public class Content : BaseResponse
    {
        public string region { get; set; }
        public Data data { get; set; }

        public class Data
        {
            public Raw raw { get; set; }
        }

        public class Raw
        {
            public Character[] Characters { get; set; }
            public Map[] Maps { get; set; }
            public Chroma[] Chromas { get; set; }
            public Skin[] Skins { get; set; }
            public Skinlevel[] SkinLevels { get; set; }
            public Attachment[] Attachments { get; set; }
            public Equip[] Equips { get; set; }
            public Theme[] Themes { get; set; }
            public Gamemode[] GameModes { get; set; }
            public Spray[] Sprays { get; set; }
            public Spraylevel[] SprayLevels { get; set; }
            public Charm[] Charms { get; set; }
            public Charmlevel[] CharmLevels { get; set; }
            public Playercard[] PlayerCards { get; set; }
            public Playertitle[] PlayerTitles { get; set; }
            public Storefrontitem[] StorefrontItems { get; set; }
            public Season[] Seasons { get; set; }
            public Competitiveseason[] CompetitiveSeasons { get; set; }
        }

        public class Character
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public string AssetName { get; set; }
            public bool IsEnabled { get; set; }
        }

        public class Map
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public string AssetName { get; set; }
            public bool IsEnabled { get; set; }
        }

        public class Chroma
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public string AssetName { get; set; }
            public bool IsEnabled { get; set; }
        }

        public class Skin
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public string AssetName { get; set; }
            public bool IsEnabled { get; set; }
        }

        public class Skinlevel
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public string AssetName { get; set; }
            public bool IsEnabled { get; set; }
        }

        public class Attachment
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public string AssetName { get; set; }
            public bool IsEnabled { get; set; }
        }

        public class Equip
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public string AssetName { get; set; }
            public bool IsEnabled { get; set; }
        }

        public class Theme
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public string AssetName { get; set; }
            public bool IsEnabled { get; set; }
        }

        public class Gamemode
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public string AssetName { get; set; }
            public bool IsEnabled { get; set; }
        }

        public class Spray
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public string AssetName { get; set; }
            public bool IsEnabled { get; set; }
        }

        public class Spraylevel
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public string AssetName { get; set; }
            public bool IsEnabled { get; set; }
        }

        public class Charm
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public string AssetName { get; set; }
            public bool IsEnabled { get; set; }
        }

        public class Charmlevel
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public string AssetName { get; set; }
            public bool IsEnabled { get; set; }
        }

        public class Playercard
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public string AssetName { get; set; }
            public bool IsEnabled { get; set; }
        }

        public class Playertitle
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public string AssetName { get; set; }
            public bool IsEnabled { get; set; }
        }

        public class Storefrontitem
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public string AssetName { get; set; }
            public bool IsEnabled { get; set; }
        }

        public class Season
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public bool IsEnabled { get; set; }
            public bool IsActive { get; set; }
            public bool DevelopmentOnly { get; set; }
        }

        public class Competitiveseason
        {
            public string ID { get; set; }
            public string SeasonID { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public bool DevelopmentOnly { get; set; }
        }
    }
}
