using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using HandIn_2.Models;

namespace HandIn_2.Data
{
   
    public class AdultService : IAdultService
    {
       private HttpClient Client = new HttpClient();
       private List<Adult> adults;

       public AdultService()
       {
           adults = new List<Adult>();
       }
        
        public async Task AddAdultAsync(Adult adult)
        {
            string uri = "https://localhost:5005/Adult";
            string message = await Client.GetStringAsync(uri);
            adults = JsonSerializer.Deserialize <List<Adult>>(message);
            int max = adults.Max(Adult => Adult.Id);
            adult.Id = (++max);
            string adultSerialized = JsonSerializer.Serialize(adult);
            StringContent content = new StringContent(adultSerialized, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await Client.PostAsync(uri, content);

        }

        public async Task<List<Adult>> getAdultsAsync()
        {

            string uri = "https://localhost:5005/Adult";
            string message = await Client.GetStringAsync(uri);
            List<Adult> adults = JsonSerializer.Deserialize <List<Adult>>(message);
            return adults;
        }

        public async Task RemoveAdultAsync(int adultID)
        {
            string uri = $"https://localhost:5005/Adult/{adultID}";
            HttpResponseMessage message = await Client.DeleteAsync(uri);
            
        }
    }
}