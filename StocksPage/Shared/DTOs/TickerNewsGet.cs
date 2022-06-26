using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksPage.Shared.DTOs
{
    public class TickerNewsGet
    {
        public string Title { get; set; }
        public string PageName { get; set; }
        public string Url { get; set; }
        public DateTime Created { get; set; }
    }
}
