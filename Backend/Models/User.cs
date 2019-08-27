using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class User
    {
        [JsonProperty("deductionId")]
        public string id;
        [JsonProperty("name")]
        public string name;
        [JsonProperty("username")]
        public string username;
        [JsonProperty("email")]
        public string email;
        [JsonProperty("phone")]
        public string phone;
        [JsonProperty("website")]
        public string website;
        [JsonProperty("company")]
        public company company;
        [JsonProperty("address")]
        public address address;
    }

    public class address
    {
        [JsonProperty("street")]
        public string street;
        [JsonProperty("suite")]
        public string suite;
        [JsonProperty("city")]
        public string city;
        [JsonProperty("zipcode")]
        public string zipcode;
        [JsonProperty("geo")]
        public geo geo;
    }


    public class geo
    {
        [JsonProperty("lat")]
        public string lat;
        [JsonProperty("lng")]
        public string lng;
    }

    public class company
    {
        [JsonProperty("name")]
        public string name;
        [JsonProperty("catchPhrase")]
        public string catchPhrase;
        [JsonProperty("bs")]
        public string bs;
    }

    
}

/*
 * 
 *   {
    "id": 1,
    "name": "Leanne Graham",
    "username": "Bret",
    "email": "Sincere@april.biz",
    "address": {
      "street": "Kulas Light",
      "suite": "Apt. 556",
      "city": "Gwenborough",
      "zipcode": "92998-3874",
      "geo": {
        "lat": "-37.3159",
        "lng": "81.1496"
      }
    },
    "phone": "1-770-736-8031 x56442",
    "website": "hildegard.org",
    "company": {
      "name": "Romaguera-Crona",
      "catchPhrase": "Multi-layered client-server neural-net",
      "bs": "harness real-time e-markets"
    }
  }
 * 
 * */
