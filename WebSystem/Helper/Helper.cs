using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebSystem.Helper
{
    public class HelperAPI
    {
        public HttpClient Initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44362/");
            return client;
        }

        public static HttpClient WebApiClient = new HttpClient();
        static HelperAPI()
        {
            WebApiClient.BaseAddress = new Uri("https://localhost:44362/api/");
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
