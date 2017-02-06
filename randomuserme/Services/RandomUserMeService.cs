using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;
using Models;

namespace Services
{
    public class RandomUserMeService
    {
        private static string RESTURL = "https://randomuser.me/api/?format=json&results={0}";
        
        public RandomUserMeService() 
        {
        }

        public static async Task<RandomUserMeSearch> GetRandomUsersByAmount(int amount)
        {
            string url = String.Format(RandomUserMeService.RESTURL, amount);

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
                        var serializer = new DataContractJsonSerializer(typeof(RandomUserMeSearch));
                        var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
                        RandomUserMeSearch obj = (RandomUserMeSearch) serializer.ReadObject(ms);

                        return obj;
                    }
                }
            }
            return null;
        }
    }
}
