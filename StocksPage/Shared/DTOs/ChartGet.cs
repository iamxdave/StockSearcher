using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cryptopage.Shared.DTOs
{
    public class ChartGet
    {
        public string ticker { get; set; }
        public int queryCount { get; set; }
        public int resultsCount { get; set; }
        public bool adjusted { get; set; }
        public PointGet[] results { get; set; }
        public string status { get; set; }
        public string request_id { get; set; }
        public int count { get; set; }
    }

    public class PointGet
    {
        public float v { get; set; }
        public float vw { get; set; }
        public float o { get; set; }
        public float c { get; set; }
        public float h { get; set; }
        public float l { get; set; }
        public long t { get; set; }
        public int n { get; set; }
    }


}
