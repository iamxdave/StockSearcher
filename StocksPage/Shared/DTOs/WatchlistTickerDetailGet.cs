﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksPage.Shared.DTOs
{
    public class WatchlistTickerDetailGet
    {
        public string LogoUrl { get; set; }
        public string Ticker { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Currency { get; set; }
        public string Cik { get; set; }
    }
}
