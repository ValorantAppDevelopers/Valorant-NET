using System;
using System.Net.Http;
using System.Threading.Tasks;
using ValorantNET.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ValorantNET
{
    public class ValorantClient
    {
        private const string Endpoint = "https://api.henrikdev.xyz";

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
            var result = await GetRequestAsync<Player>($"/valorant/v1/profile/{name}/{tag}");
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
            var result = await GetRequestAsync<Match>($"/valorant/v1/matches/{name}/{tag}");
            return result;
        }

        /// <summary>
        /// Returns a match overview
        /// </summary>
        /// <param name="matchId"></param>
        /// <returns></returns>
        public async Task<MatchInfo> GetMatchInfoAsync(string matchId)
        {
            var result = await GetRequestAsync<MatchInfo>($"/valorant/v1/match/{matchId}");
            return result;
        }

        private async Task<T> GetRequestAsync<T>(string request)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Endpoint);

                    var result = await client.GetAsync(request);
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
