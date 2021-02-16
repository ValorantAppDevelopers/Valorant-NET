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
            var result = await GetRequestAsyncV1<Match>($"/matches/{Name}/{Tag}");
            return result;
        }

        /// <summary>
        /// Returns a list of 10 matches that where played by this user
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
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
            var result = await GetRequestAsyncV1<MatchInfo>($"/match/{matchId}");
            return result;
        }

        /// <summary>
        /// Get the server status filter by region
        /// </summary>
        /// <param name="matchId"></param>
        /// <returns></returns>
        public async Task<Status> GetServerStatusAsync()
        {
            var result = await GetRequestAsyncV1<Status>($"/status/{Region.ToString().ToLower()}");
            return result;
        }

        /// <summary>
        /// Returns the Ingame PUUID of requested user
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
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
            var result = await GetRequestAsyncV1<Leaderboard>($"/leaderboard/{Region.ToString().ToLower()}");
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
        /// Get website content
        /// </summary>
        /// <param name="countryCode"></param>
        /// <returns></returns>
        public async Task<Website> GetWebsiteAsync(CountryCodes countryCode)
        {
            var result = await GetRequestAsyncV1<Website>($"/website/{countryCode.ToString().Replace("_","-").ToLower()}");
            return result;
        }

        /// <summary>
        /// Get website content filtered
        /// </summary>
        /// <param name="countryCode"></param>
        /// <returns></returns>
        public async Task<Website> GetWebsiteAsync(CountryCodes countryCode, WebsiteFilter websiteFilter)
        {
            var result = await GetRequestAsyncV1<Website>($"/website/{countryCode.ToString().Replace("_", "-").ToLower()}?filter={websiteFilter}");
            return result;
        }

        /// <summary>
        /// Get history rank movement of the player
        /// </summary>
        /// <returns></returns>
        public async Task<MMR> GetHistoryMMR()
        {
            var result = await GetRequestAsyncV1<MMR>($"/mmr-history/{Region.ToString()}/{Name}/{Tag}");
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
            catch(Exception exc)
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
    }
}
