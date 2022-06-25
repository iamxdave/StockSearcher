namespace StocksPage.Server.Models
{
    public class TickerDetail
    {
        public int IdTickerDetail { get; set; }
        public string? LogoUrl { get; set; }
        public string Ticker { get; set; }
        public string Name { get; set; }
        public string? SicDescription { get; set; }
        public string? Country { get; set; }
        public string? Currency { get; set; }
        public string? Cik { get; set; }
        public string? Description { get; set; }
        public int? TotalEmployees { get; set; }
        public string? Homepage { get; set; }
        public virtual IEnumerable<Watchlist> Watchlist { get; set; }
    }
}
