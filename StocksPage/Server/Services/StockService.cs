using Microsoft.EntityFrameworkCore;
using StocksPage.Server.Data;
using StocksPage.Server.Models;

namespace StocksPage.Server.Services
{
    public class StockService : IStockService
    {
        private readonly ApplicationDbContext _context;
        public StockService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<TickerDetail> GetTickerDetail(string tickerName)
        {
            return _context.TickerDetails.Where(e => e.Ticker == tickerName);
        }
        public IQueryable<TickerDetail> GetWatchlistTickerDetails(int idWatchlistTickerDetail)
        {
            return _context.TickerDetails.Where(e => e.IdWatchlistTickerDetail == idWatchlistTickerDetail);
        }
        public IQueryable<TickerName> GetTickerName(string tickerName)
        {
            return _context.TickerNames.Where(e => e.Ticker == tickerName);
        }
        public IQueryable<TickerName> GetTickerNames()
        {
            return _context.TickerNames;
        }

        public void Delete<T>(T entity) where T : class
        {
            var entry = _context.Entry(entity);
            entry.State = EntityState.Deleted;
        }
        public async Task CreateAsync<T>(T entity) where T : class
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
