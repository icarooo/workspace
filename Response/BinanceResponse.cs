﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btc.Response
{
    public class BinanceResponse
    {
        public List<List<decimal>> asks { get; set; }
        public List<List<decimal>> bids { get; set; }
    }
}
