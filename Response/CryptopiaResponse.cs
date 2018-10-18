using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btc.Response
{
    public class CryptopiaResponse
    {
        public bool Success { get; set; }
        public CryptopiaData Data{ get; set; }
    }
    public class CryptopiaData
    {
        public decimal AskPrice { get; set; }
        public decimal BidPrice { get; set; }
    }
}
