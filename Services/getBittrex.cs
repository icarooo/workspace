using btc.Response;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btc.Services
{
    public class GetBittrex
    {
        public static BittrexResponse get(string moeda)
        {
            var client = new RestClient("https://bittrex.com/api/v1.1/public/");
            var request = new RestRequest(string.Format("getmarketsummary?market=btc-{0}",moeda), Method.GET);
            IRestResponse response = client.Execute(request);
            var ew = JsonConvert.DeserializeObject<BittrexResponse>(response.Content);
            return ew;
        }
    }
}
