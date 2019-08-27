using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Backend.Contracts;
using Backend.Models;
using Newtonsoft.Json;

namespace Backend.ActionClasses
{
    public class FetchUsers : IFetchUsers
    {
        public async Task<IList<User>> GetUsers()
        {
            HttpClient client = new HttpClient();
            List<User> users = null;

            // We can read this from configuration file
            string Uri = "https://jsonplaceholder.typicode.com/users";

            try
            {
                HttpResponseMessage response = await client.GetAsync(Uri);

                if (response.IsSuccessStatusCode)
                {
                    string responseResult = await response.Content.ReadAsStringAsync();

                    // We can return simple response string to client but converting to local class 
                    // would provide more control over the data manupulation at server side.

                    users = JsonConvert.DeserializeObject<List<User>>(responseResult);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return users;
        }
    }
}
