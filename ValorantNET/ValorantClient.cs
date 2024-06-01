using System;
using System.Net.Http;
using System.Threading.Tasks;
using ValorantNET.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using static ValorantNET.Enums;

namespace ValorantNET
{
    public class ValorantClient
    {
        private const string Endpoint = "https://api.henrikdev.xyz";
        private const string Route = "/valorant";

        public string Name { get; private set; }
        public string Tag { get; private set; }
        public Regions Region { get; private set; }

        public ValorantClient(string name, string tag, Regions region)
        {
            Name = name;
            Tag = tag;
            Region = region;
        }

        /// <summary>
        /// Returns players general stats
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
        [Obsolete]
        public async Task<Player> GetStatsAsync()
        {
            var result = await GetRequestAsyncV2<Player>($"/profile/{Name}/{Tag}");
            return result;
        }

        /// <summary>
        /// Returns players general stats
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
        [Obsolete]
        public async Task<Player> GetStatsAsync(EpisodeFilter episodeFilter)
        {
            var result = await GetRequestAsyncV2<Player>($"/profile/{Name}/{Tag}?filter=" + episodeFilter.ToString().ToLower());
            return result;
        }

        /// <summary>
        /// Returns a list of 10 matches that where played by this user
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
        public async Task<Match> GetMatchesAsync()
        {
            var result = await GetRequestAsyncV3<Match>($"/matches/{Region}/{Name}/{Tag}");
            return result;
        }

        /// <summary>
        /// Returns a list of 10 matches that where played by this user
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
        [Obsolete]
        public async Task<Match> GetMatchesAsync(MatchFilter matchType)
        {
            var result = await GetRequestAsyncV1<Match>($"/matches/{Name}/{Tag}?filter=" + matchType.ToString().ToLower());
            return result;
        }

        /// <summary>
        /// Returns a match overview
        /// </summary>
        /// <param name="matchId"></param>
        /// <returns></returns>
        public async Task<MatchInfo> GetMatchInfoAsync(string matchId)
        {
            var result = await GetRequestAsyncV2<MatchInfo>($"/match/{matchId}");
            return result;
        }

        /// <summary>
        /// Get the server status filter by region
        /// </summary>
        /// <param name="matchId"></param>
        /// <returns></returns>
        public async Task<Status> GetServerStatusAsync()
        {
            var result = await GetRequestAsyncV1<Status>($"/status/{Region.ToString()}");
            return result;
        }

        /// <summary>
        /// Returns the Ingame PUUID of requested user
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
        [Obsolete]
        public async Task<PUUID> GetPUUIDAsync()
        {
            var result = await GetRequestAsyncV1<PUUID>($"/puuid/{Name}/{Tag}");
            return result;
        }

        /// <summary>
        /// Returns the Ingame Leaderboard list for the selected region
        /// </summary>
        /// <param name="region"></param>
        /// <returns></returns>
        public async Task<Leaderboard> GetLeaderboardAsync()
        {
            var result = await GetRequestAsyncV1<Leaderboard>($"/leaderboard/{Region.ToString()}");
            return result;
        }

        /// <summary>
        /// Return the ingame leaderboard on the current user
        /// </summary>
        /// <returns></returns>
        public async Task<Leaderboard> GetSelfLeaderboardAsync()
        {
            var result = await GetRequestAsyncV1<Leaderboard>($"/leaderboard/{Region.ToString()}?name={Name}&tag={Tag}");
            return result;
        }

        /// <summary>
        /// Get the content of the game
        /// </summary>
        /// <returns></returns>
        public async Task<Content> GetContentAsync()
        {
            var result = await GetRequestAsyncV1<Content>($"/content");
            return result;
        }

        /// <summary>
        /// Get offers item on store
        /// </summary>
        /// <returns></returns>
        public async Task<StoreOffer> GetStoreOffersAsync()
        {
            var result = await GetRequestAsyncV1<StoreOffer>($"/store-offers");
            return result;
        }

        /// <summary>
        /// Get featured/bundle items on store
        /// </summary>
        /// <returns></returns>
        public async Task<StoreFeatured> GetStoreFeaturedAsync()
        {
            var result = await GetRequestAsyncV1<StoreFeatured>($"/store-featured");
            return result;
        }

        /// <summary>
        /// Get website articles
        /// </summary>
        /// <param name="countryCode"></param>
        /// <returns></returns>
        public async Task<Website> GetWebsiteArticlesAsync(CountryCodes countryCode)
        {
            var result = await GetRequestAsyncV1<Website>($"/website/{countryCode.ToString().Replace("_", "-").ToLower()}");
            return result;
        }

        /// <summary>
        /// Get website articles filtered
        /// </summary>
        /// <param name="countryCode"></param>
        /// <returns></returns>
        public async Task<Website> GetWebsiteArticlesAsync(CountryCodes countryCode, WebsiteFilter websiteFilter)
        {
            var result = await GetRequestAsyncV1<Website>($"/website/{countryCode.ToString().Replace("_", "-").ToLower()}?filter={websiteFilter}");
            return result;
        }

        /// <summary>
        /// Get history rank movement of the player
        /// </summary>
        /// <returns></returns>
        public async Task<MMRHistory> GetMMRHistoryAsync()
        {
            var result = await GetRequestAsyncV1<MMRHistory>($"/mmr-history/{Region.ToString()}/{Name}/{Tag}");
            return result;
        }

        /// <summary>
        /// MMR History for previous Seasons
        /// </summary>
        /// <returns></returns>
        public async Task<MMR> GetMMRAsync()
        {
            var result = await GetRequestAsyncV2<MMR>($"/mmr/{Region.ToString()}/{Name}/{Tag}");
            return result;
        }

        /// <summary>
        /// MMR History for previous Seasons filtered
        /// </summary>
        /// <returns></returns>
        public async Task<MMR> GetMMRAsync(EpisodeFilter episodeFilter)
        {
            var result = await GetRequestAsyncV2<MMR>($"/mmr/{Region.ToString()}/{Name}/{Tag}?filter={episodeFilter}");
            return result;
        }

        /// <summary>
        /// Get MMR by PUUID - Object class to be defined
        /// </summary>
        /// <param name="puuid"></param>
        /// <returns></returns>
        public async Task<dynamic> GetMMRByPUUIDAsync(string puuid)
        {
            var result = await GetRequestAsyncV1<dynamic>($"/by-puuid/mmr/{Region.ToString()}/{puuid}");
            return result;
        }

        /// <summary>
        /// Get the presence and live match status of user
        /// </summary>
        /// <returns></returns>
        [Obsolete]
        public async Task<LivePresence> GetPlayerMatchStatusAsync()
        {
            var result = await GetRequestAsyncV1<LivePresence>($"/live-match/{Name}/{Tag}");
            return result;
        }



        /// <summary>
        /// Return list of matches by providing PUUID - Object class to be defined
        /// </summary>
        /// <param name="puuid"></param>
        /// <returns></returns>
        public async Task<dynamic> GetMatchesByPUUIDAsync(string puuid)
        {
            var result = await GetRequestAsyncV1<dynamic>($"/by-puuid/matches/{Region.ToString()}/{puuid}");
            return result;
        }

        /// <summary>
        /// Get account base information
        /// </summary>
        /// <returns></returns>
        public async Task<Account> GetAccountAsync()
        {
            var result = await GetRequestAsyncV1<Account>($"/account/{Name}/{Tag}");
            return result;
        }

        private async Task<T> GetRequestAsyncV1<T>(string request)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Endpoint);

                    var result = await client.GetAsync(Route + "/v1" + request);
                    var contents = await result.Content.ReadAsStringAsync();
                    var modelObject = JsonConvert.DeserializeObject<T>(contents);

                    return modelObject;
                }
            }
            catch (Exception exc)
            {
                return default(T);
            }
        }

        private async Task<T> GetRequestAsyncV2<T>(string request)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Endpoint);

                    var result = await client.GetAsync(Route + "/v2" + request);
                    var contents = await result.Content.ReadAsStringAsync();
                    var modelObject = JsonConvert.DeserializeObject<T>(contents);

                    return modelObject;
                }
            }
            catch (Exception exc)
            {
                return default(T);
            }
        }

        private async Task<T> GetRequestAsyncV3<T>(string request)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Endpoint);

                    var result = await client.GetAsync(Route + "/v3" + request);
                    var contents = await result.Content.ReadAsStringAsync();
                    var modelObject = JsonConvert.DeserializeObject<T>(contents);

                    return modelObject;
                }
            }
            catch (Exception exc)
            {
                return default(T);
            }
        }
    }
}
