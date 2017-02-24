using Cats.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats
{
    class Repository
    {
        List<Cat> Cats;
        public async Task<List<Cat>> GetCats()
        {
            var URLWebAPI = "http://demos.ticapacitacion.com/cats";
            using(var Client = new System.Net.Http.HttpClient())
            {
                var JSON = await Client.GetStringAsync(URLWebAPI);
                Cats = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Cat>>(JSON);
            }
            return Cats;
        }
    }
}
