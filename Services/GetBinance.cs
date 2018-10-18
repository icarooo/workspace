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
    public class GetBinance
    {
        public static BinanceResponse get(string moeda)
        {
            var client = new RestClient("https://api.binance.com/");
            var request = new RestRequest(string.Format("api/v1/depth?symbol={0}BTC&limit=5", moeda.ToUpper()), Method.GET);
            IRestResponse response = client.Execute(request);
            try
            {

                return JsonConvert.DeserializeObject<BinanceResponse>(response.Content.Replace(",[]", ""));
            }
            catch
            {
                return null;
            }
        }
    }
}
