using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;

namespace YourHealth.Services
{
    public class Authentication
    {

        private static readonly string authApiURL = "http://localhost:3000/api/auth";

        public Authentication()
        {
        }

        public static async Task Login(string username, string password) 
        {
            using (HttpClient httpClient = new HttpClient()) 
            {
                IEnumerable<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>(username, password)
                };
                HttpContent queries = new FormUrlEncodedContent(data);

                using (HttpResponseMessage response = await httpClient.PostAsync(authApiURL, queries))
                {

                }
            }
        }
    }
}
