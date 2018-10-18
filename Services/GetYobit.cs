using btc.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btc.Services
{
    public class GetYobit
    {
        public static YobitResponse get(string moeda)
        {
            var client = new RestClient("https://yobit.net/");
            var request = new RestRequest(string.Format("api/2/{0}_btc/depth", moeda), Method.GET);
            IRestResponse response = client.Execute(request);
            try
            {
                return JsonConvert.DeserializeObject<YobitResponse>(response.Content);
            }
            catch
            {
                return null;
            }
        }
    }
}
