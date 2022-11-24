using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CCTOOL
{
    [Serializable]
    public class binCheck
    {
        public string _cardName;
        public string _country;
        public string _cardLevel;
        public string _cardType;
        public string _cardNum;
        public bool _isValid;
        public  async Task CheckBin(string card)
        {
            var url = string.Format("https://bin-ip-checker.p.rapidapi.com/?bin={0}",card.Substring(0,6));
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(url),
                Headers = {
                  {
                     "X-RapidAPI-Key",
                     "98ad03968bmsh461d87cbd22924cp19e3d0jsn2fca7780cfdc"
                  },
                  {
                     "X-RapidAPI-Host",
                     "bin-ip-checker.p.rapidapi.com"
                  },
               },

                Content = new StringContent("{\r\"bin\": \"{0}\"\r}")
                {
                    Headers = {
                     ContentType = new MediaTypeHeaderValue("application/json")
                  }
                }
            };
            var jsonString = string.Empty;
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                jsonString = await response.Content.ReadAsStringAsync();
            }
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(jsonString);
            _cardName = myDeserializedClass.BIN.issuer.name;
            _country = myDeserializedClass.BIN.country.country;
            _cardLevel = myDeserializedClass.BIN.level;
            _cardType = myDeserializedClass.BIN.type;
            _cardNum = myDeserializedClass.BIN.number.ToString();
            _isValid = myDeserializedClass.success;
           
        }
        public class BIN
        {
            public bool valid { get; set; }
            public int number { get; set; }
            public int length { get; set; }
            public string scheme { get; set; }
            public string brand { get; set; }
            public string type { get; set; }
            public string level { get; set; }
            public string currency { get; set; }
            public Issuer issuer { get; set; }
            public Country country { get; set; }
        }

        public class Country
        {
            public string country { get; set; }
            public string numeric { get; set; }
            public string capital { get; set; }
            public string idd { get; set; }
            public string alpha2 { get; set; }
            public string alpha3 { get; set; }
            public string language { get; set; }
            public string language_code { get; set; }
            public double latitude { get; set; }
            public double longitude { get; set; }
        }

        public class Issuer
        {
            public string name { get; set; }
            public string website { get; set; }
            public string phone { get; set; }
        }

        public class Root
        {
            public bool success { get; set; }
            public int code { get; set; }
            public BIN BIN { get; set; }
        }
    }
}