namespace StocksPage.Server.Models
{
    public class WatchlistTickerDetail
    {
        public int IdWatchlistTickerDetail { get; set; }
        public virtual IEnumerable<TickerDetail> TickerDetails { get; set; }
    }
}
