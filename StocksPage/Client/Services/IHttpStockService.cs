using StocksPage.Shared.DTOs;

namespace StocksPage.Client.Services
{
    public interface IHttpStockService
    {
        public Task<TickerDetailGet> GetTickerDetail(string tickerName);
        public Task<IEnumerable<WatchlistGet>?> GetTickersFromWatchlist(string idUser);
        public Task<IEnumerable<TickerNameGet>> GetTickerNames();
        public Task<IEnumerable<TickerChartGet>> GetTickerChart(string tickerName);
        public Task<IEnumerable<TickerNewsGet>?> GetTickerNews(string tickerName);
        public Task AddTickerToWatchlist(TickerDetailGet ticker, string idUser);
        public Task DeleteTickerFromWatchlist(string tickerName, string idUser);
    }
}
