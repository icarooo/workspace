using btc.Response;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace btc.Services
{
    public class GetCryptopia
    {
        public static CryptopiaResponse get(string moeda)
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var client = new RestClient("https://www.cryptopia.co.nz/api/GetMarket/");
            var request = new RestRequest(string.Format("{0}_BTC", moeda.ToUpper()), Method.GET);
            IRestResponse response = client.Execute(request);
            var ew = JsonConvert.DeserializeObject<CryptopiaResponse>(response.Content);
            return ew;
        }
    }
}
