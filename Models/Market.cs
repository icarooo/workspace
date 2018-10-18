using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btc.Models
{
    public class Market
    {
        public string Exchange { get; set; }
        public string Coin { get; set; }
        public decimal bid { get; set; }
        public decimal ask { get; set; }
    }
}
