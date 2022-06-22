

using StocksPage.Server.Models;

namespace StocksPage.Server.Services
{
    public interface IStockService
    {
        public IQueryable<TickerDetail> GetTickerDetail(string tickerName);
        public IQueryable<TickerDetail> GetWatchlistTickerDetails(int id);
        public IQueryable<TickerName> GetTickerName(string tickerName);
        public IQueryable<TickerName> GetTickerNames();
        public void Delete<T>(T entity) where T : class;
        public Task CreateAsync<T>(T entity) where T : class;
        public Task SaveChangesAsync();
    }
}
