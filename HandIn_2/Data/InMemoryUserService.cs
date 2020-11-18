using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using HandIn_2.Models;

namespace HandIn_2.Data
{
    public class InMemoryUserService : IUserService
    {
        private HttpClient Client;
        public  InMemoryUserService()
        {
            Client = new HttpClient();
        }
        
        public async  Task<User> ValidateUser(string userName, string password)
        {
            string uri = "https://localhost:5007/User";
            string message = await Client.GetStringAsync(uri);
            List<User> users = JsonSerializer.Deserialize<List<User>>(message);
            User first;
            try
            {
                first = users.First(user => user.userName==userName);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("User not found");
            }
            if (!first.password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }
            
            
           
            


            return first;
        }
    }
}