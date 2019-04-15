using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SpaceX.API.Helpers
{
    public class APIHelper
    {
        public HttpClient Initial()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var Client = new HttpClient();
            Client.BaseAddress = new Uri("https://api.spacexdata.com/v3");
            return Client;
        }
    }
}
