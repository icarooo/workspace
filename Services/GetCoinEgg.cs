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
    public class GetCoinEgg
    {
        public static CoineggResponse get(string moeda)
        {
            var client = new RestClient("https://api.coinegg.im/api/v1/depth/region/btc");
            var request = new RestRequest(string.Format("?coin={0}", moeda), Method.GET);
            IRestResponse response = client.Execute(request);
            try
            {
                return JsonConvert.DeserializeObject<CoineggResponse>(response.Content);
            }
            catch
            {
                return null;
            }
        }
    }
}
