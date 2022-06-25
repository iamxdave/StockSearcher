namespace StocksPage.Server.Models
{
    public class Watchlist
{
    public int IdWatchlist { get; set; }
    public string IdUser { get; set; }
    public int IdTickerDetail { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual TickerDetail TickerDetail { get; set; }
}
}
