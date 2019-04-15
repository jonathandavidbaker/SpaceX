using SpaceX.API.Helpers;
using SpaceX.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpaceX.API.Processors
{
    public class LaunchProcessor
    {
        public static async Task<List<LaunchModel>> GetAllLaunches()
        {
            APIHelper _api = new APIHelper();
            List<LaunchModel> launches = new List<LaunchModel>();
            HttpClient client = _api.Initial();
            string url = client.BaseAddress + "/launches";
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            HttpResponseMessage res = await client.GetAsync(url);
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                launches = JsonConvert.DeserializeObject<List<LaunchModel>>(result, settings);
            }
            return launches;
        }        
    }
}
