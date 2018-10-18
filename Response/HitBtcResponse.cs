using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btc.Response
{
    public class HitBtcResponse
    {
        public List<HitBtcData> ask { get; set; }
        public List<HitBtcData> bid { get; set; }

    }
    public class HitBtcData
    {
        public decimal price { get; set; }
    }
}
