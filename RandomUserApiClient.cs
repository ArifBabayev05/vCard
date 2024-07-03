using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vCard
{
    public class RandomUserApiClient
    {
        private static readonly HttpClient client = new HttpClient();
        
        public async Task<string> GetRandomUserData()
        {
            string url = "https://randomuser.me/api/";
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
