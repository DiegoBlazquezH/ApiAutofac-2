using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;

namespace EjemploApi.DataAccess.WSVueling
{
    public class WSConfiguration
    {
        public class ServiceConfiguration
        {
            public static HttpClient InitClient(HttpClient client)
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["BaseApiUrl"]);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return client;
            }
        }
    }
}
