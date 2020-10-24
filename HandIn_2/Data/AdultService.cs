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

       public AdultService()
        {
            
        }
        
        public async Task AddAdultAsync(Adult adult)
        {
            string uri = "http://dnp.metamate.me/Adults";
            string adultSerialized = JsonSerializer.Serialize(adult);
            StringContent content = new StringContent(adultSerialized, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await Client.PutAsync(uri, content);

        }

        public async Task<List<Adult>> getAdultsAsync()
        {

            string uri = "http://dnp.metamate.me/Adults";
            string message = await Client.GetStringAsync(uri);
            List<Adult> adults = JsonSerializer.Deserialize <List<Adult>>(message);
            return adults;
        }

        public async Task RemoveAdultAsync(int adultID)
        {
            string uri = $"http://dnp.metamate.me/Adults/{adultID}";
            HttpResponseMessage message = await Client.DeleteAsync(uri);
            
        }
    }
}