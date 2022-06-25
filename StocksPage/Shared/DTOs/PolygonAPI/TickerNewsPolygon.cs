using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksPage.Shared.DTOs.PolygonAPI
{

    public class TickerNewsPolygon
    {
        public New[] results { get; set; }
        public string status { get; set; }
        public string request_id { get; set; }
        public int count { get; set; }
        public string next_url { get; set; }
    }

    public class New
    {
        public string id { get; set; }
        public Publisher publisher { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public DateTime published_utc { get; set; }
        public string article_url { get; set; }
        public string[] tickers { get; set; }
        public string amp_url { get; set; }
        public string image_url { get; set; }
        public string description { get; set; }
        public string[] keywords { get; set; }
    }

    public class Publisher
    {
        public string name { get; set; }
        public string homepage_url { get; set; }
        public string logo_url { get; set; }
        public string favicon_url { get; set; }
    }

}
