using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksPage.Shared.DTOs.PolygonAPI
{

    public class TickerDetailPolygon
    {
        public TDInfo results { get; set; }
        public string status { get; set; }
        public string request_id { get; set; }
    }

    public class TDInfo
    {
        public string ticker { get; set; }
        public string name { get; set; }
        public string market { get; set; }
        public string locale { get; set; }
        public string primary_exchange { get; set; }
        public string type { get; set; }
        public bool active { get; set; }
        public string currency_name { get; set; }
        public string cik { get; set; }
        public string composite_figi { get; set; }
        public string share_class_figi { get; set; }
        public float market_cap { get; set; }
        public string phone_number { get; set; }
        public TDAddress address { get; set; }
        public string description { get; set; }
        public string sic_code { get; set; }
        public string sic_description { get; set; }
        public string ticker_root { get; set; }
        public string homepage_url { get; set; }
        public int total_employees { get; set; }
        public string list_date { get; set; }
        public TDBranding branding { get; set; }
        public long share_class_shares_outstanding { get; set; }
        public long weighted_shares_outstanding { get; set; }
    }

    public class TDAddress
    {
        public string address1 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postal_code { get; set; }
    }

    public class TDBranding
    {
        public string logo_url { get; set; }
        public string icon_url { get; set; }
    }




}
