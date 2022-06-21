using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cryptopage.Shared.DTOs
{
    public class SearchGet
    {
        public CompanyGet[] results { get; set; }
        public string status { get; set; }
        public string request_id { get; set; }
        public int count { get; set; }
        public string? next_url { get; set; }


    }
    public class CompanyGet
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
        public DateTime last_updated_utc { get; set; }
    }
}
