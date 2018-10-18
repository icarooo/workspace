using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btc.Response
{
    public class BittrexResponse
    {
        public bool success { get; set; }
        public List<BittrexResult> result{ get; set; }

    }
    public class BittrexResult
    {
        public decimal bid { get; set; }
        public decimal ask { get; set; }
    }
}
