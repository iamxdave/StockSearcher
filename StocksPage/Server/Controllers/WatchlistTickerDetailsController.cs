using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StocksPage.Server.Models;
using StocksPage.Server.Services;
using StocksPage.Shared.DTOs;

namespace StocksPage.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WatchlistTickerDetailsController : ControllerBase
    {
        private readonly IStockService _service;

        public WatchlistTickerDetailsController(IStockService service)
        {
            _service = service;
        }

        [HttpGet("{idWatchlist}")]
        public async Task<IEnumerable<WatchlistTickerDetailGet>>? GetWatchlistTickerDetails(int idWatchlist)
        {
            var watchlistTickerDetails = _service.GetWatchlistTickerDetails(idWatchlist);

            if (watchlistTickerDetails == null || !watchlistTickerDetails.Any())
            {
                return Enumerable.Empty<WatchlistTickerDetailGet>();
            }

            return watchlistTickerDetails.Select(e => new WatchlistTickerDetailGet
            {
                LogoUrl = e.LogoUrl,
                Ticker = e.Ticker,
                Name = e.Name,
                Country = e.Country,
                Currency = e.Currency,
                Cik = e.Cik
            }).ToList();
        }

        [HttpDelete("{tickerName}")]
        public async Task DeleteWatchlistTickerDetail(string tickerName)
        {
            var tickerDetail = await _service.GetTickerDetail(tickerName).FirstOrDefaultAsync();

            if (tickerDetail != null)
            {
                tickerDetail.IdWatchlistTickerDetail = null;
                await _service.SaveChangesAsync();
            }
        }
    }
}
