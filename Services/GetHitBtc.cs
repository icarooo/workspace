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
    public class GetHitBtc
    {
        public static HitBtcResponse get(string moeda)
        {
            var client = new RestClient("https://api.hitbtc.com/");
            var request = new RestRequest(string.Format("api/2/public/orderbook/{0}BTC", moeda.ToUpper()), Method.GET);
            IRestResponse response = client.Execute(request);
            try
            {
                return JsonConvert.DeserializeObject<HitBtcResponse>(response.Content);
            }
            catch
            {
                return null;
            }

        }
    }
}
