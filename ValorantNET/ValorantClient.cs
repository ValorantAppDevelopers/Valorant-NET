using System;
using System.Net.Http;
using System.Threading.Tasks;
using ValorantNET.Models;
using Newtonsoft.Json;
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
        /// <returns></returns>
        public async Task<Player> GetStatsAsync(string name, string tag)
        {
            var result = await GetRequestAsync<Player>($"/valorant/v1/profile/{name}/{tag}");
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
