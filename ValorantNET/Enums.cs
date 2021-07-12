using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantNET
{
    public class Enums
    {
        public enum Regions
        {
            AP,
            //BR,
            EU,
            //LATAM,
            NA,
            KR,
        }

        public enum CountryCodes
        {
            en_us,
            en_gb,
            de_de,
            es_es,
            fr_fr,
            it_it,
            ru_ru,
            tr_tr,
            es_mx,
            ja_jp,
            ko_kr,
            pt_br
        }

        public enum WebsiteFilter
        {
            game_updates, 
            dev, 
            esports,
            announcements
        }

        public enum MatchFilter
        {
            competitive,
            spikerush,
            deathmatch,
            unrated
        }

        public enum EpisodeFilter
        {
            e2a1,
            e1a3,
            e1a2,
            e1a1
        }
    }
}
