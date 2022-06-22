using StocksPage.Shared.DTOs;

namespace StocksPage.Client.Services
{
    public interface IHttpStockService
    {
        public Task<TickerDetailGet> GetTickerDetail(string tickerName);
        public Task<IEnumerable<WatchlistTickerDetailGet>> GetTickerDetailsFromWatchlist(int idWatchlist);
        public Task<IEnumerable<TickerNameGet>> GetTickerNames();
        public Task<IEnumerable<TickerChartGet>> GetTickerChart(string tickerName);
        public Task DeleteDetailFromWatchlist(string tickerName);
    }
}
