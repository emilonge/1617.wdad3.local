using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;
using Com.Ahs.Forcastio.Models;

namespace Com.Ahs.Forcastio.Services
{
    public class ForecastIOService
    {
        private static string KEY = "c763892f527b7a925edf3f17c57aef35";// Change this key with your own key
        private static string RESTURL = "https://api.darksky.net/forecast/{0}/{1},{2}?units={3}";
        
        public ForecastIOService() 
        {
        }

        public static async Task<ForecastIO> GetWeatherFromLatLng(string lat, string lng)
        {
            string url = String.Format(ForecastIOService.RESTURL, ForecastIOService.KEY, lat, lng, "si");

            using (var handler = new HttpClientHandler())
            {
                handler.AllowAutoRedirect = false;
                //handler.ServerCertificateCustomValidationCallback = (msg, cert, chain, errors) => true;

                using (var client = new HttpClient(handler))
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        var serializer = new DataContractJsonSerializer(typeof(ForecastIO));
                        var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
                        ForecastIO forecast = (ForecastIO) serializer.ReadObject(ms);

                        return forecast;
                    }
                }
            }
            return null;
        }
    }
}
