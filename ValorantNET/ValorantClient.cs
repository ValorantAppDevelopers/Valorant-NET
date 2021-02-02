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
        private const string ApiVersion = "/v1";

        public ValorantClient()
        {

        }

        /// <summary>
        /// Returns players general stats
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
        public async Task<Player> GetStatsAsync(string name, string tag)
        {
            var result = await GetRequestAsync<Player>($"/profile/{name}/{tag}");
            return result;
        }

        /// <summary>
        /// Returns a list of 10 matches that where played by this user
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
        public async Task<Match> GetMatchesAsync(string name, string tag)
        {
            var result = await GetRequestAsync<Match>($"/matches/{name}/{tag}");
            return result;
        }

        /// <summary>
        /// Returns a match overview
        /// </summary>
        /// <param name="matchId"></param>
        /// <returns></returns>
        public async Task<MatchInfo> GetMatchInfoAsync(string matchId)
        {
            var result = await GetRequestAsync<MatchInfo>($"/match/{matchId}");
            return result;
        }

        /// <summary>
        /// Get the server status filter by region
        /// </summary>
        /// <param name="matchId"></param>
        /// <returns></returns>
        public async Task<Status> GetServerStatusAsync(Regions region)
        {
            var result = await GetRequestAsync<Status>($"/status/{region.ToString().ToLower()}");
            return result;
        }

        /// <summary>
        /// Returns the Ingame PUUID of requested user
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
        public async Task<PUUID> GetPUUIDAsync(string name, string tag)
        {
            var result = await GetRequestAsync<PUUID>($"/puuid/{name}/{tag}");
            return result;
        }

        /// <summary>
        /// Returns the Ingame Leaderboard list for the selected region
        /// </summary>
        /// <param name="region"></param>
        /// <returns></returns>
        public async Task<Leaderboard> GetLeaderboardAsync(Regions region)
        {
            var result = await GetRequestAsync<Leaderboard>($"/leaderboard/{region.ToString().ToLower()}");
            return result;
        }

        /// <summary>
        /// Get the content of the game
        /// </summary>
        /// <returns></returns>
        public async Task<Content> GetContentAsync()
        {
            var result = await GetRequestAsync<Content>($"/content");
            return result;
        }

        /// <summary>
        /// Get offers item on store
        /// </summary>
        /// <returns></returns>
        public async Task<StoreOffer> GetStoreOffersAsync()
        {
            var result = await GetRequestAsync<StoreOffer>($"/store-offers");
            return result;
        }

        /// <summary>
        /// Get featured/bundle items on store
        /// </summary>
        /// <returns></returns>
        public async Task<StoreFeatured> GetStoreFeaturedAsync()
        {
            var result = await GetRequestAsync<StoreFeatured>($"/store-featured");
            return result;
        }

        /// <summary>
        /// Get website content
        /// </summary>
        /// <param name="countryCode"></param>
        /// <returns></returns>
        public async Task<Website> GetWebsiteAsync(CountryCodes countryCode)
        {
            var result = await GetRequestAsync<Website>($"/website/{countryCode.ToString().Replace("_","-").ToLower()}");
            return result;
        }

        /// <summary>
        /// Get website content filtered
        /// </summary>
        /// <param name="countryCode"></param>
        /// <returns></returns>
        public async Task<Website> GetWebsiteAsync(CountryCodes countryCode, WebsiteFilter websiteFilter)
        {
            var result = await GetRequestAsync<Website>($"/website/{countryCode.ToString().Replace("_", "-").ToLower()}?filter={websiteFilter}");
            return result;
        }

        private async Task<T> GetRequestAsync<T>(string request)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Endpoint);

                    var result = await client.GetAsync(Route + ApiVersion + request);
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
    }
}
