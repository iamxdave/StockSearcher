using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StocksPage.Server.Models;
using StocksPage.Server.Services;
using StocksPage.Shared.DTOs;

namespace StocksPage.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WatchlistsController : ControllerBase
    {
        private readonly IStockService _service;
        private readonly IConfiguration _configuration;

        public WatchlistsController(IStockService service, IConfiguration configuration)
        {
            _service = service;
            _configuration = configuration;
        }

        [HttpGet("{idUser}")]
        public IEnumerable<WatchlistGet>? GetWatchlist(string idUser)
        {
            var tickerDetails = _service.GetTickerDetailsInWatchlist(idUser);

            if (tickerDetails == null || !tickerDetails.Any())
            {
                return Enumerable.Empty<WatchlistGet>();
            }

            return tickerDetails.Select(e => new WatchlistGet
            {
                LogoUrl = e.LogoUrl == null ? null : e.LogoUrl + "?apiKey=" + _configuration.GetValue<string>("PolygonAPIKey"),
                Ticker = e.Ticker,
                Name = e.Name,
                Country = e.Country.ToUpper(),
                Currency = e.Currency.ToUpper(),
                Cik = e.Cik
            }).ToList();
        }

        [HttpPost("{idUser}")]
        public async Task PostWatchlist(string idUser, TickerDetailGet body)
        {
            var watchlist = _service.GetTickerDetailsInWatchlist(idUser).Where(e => e.Ticker == body.Ticker);

            if (watchlist == null || !watchlist.Any())
            {
                await _service.CreateAsync(new Watchlist
                {
                    IdUser = idUser,
                    IdTickerDetail = _service.GetTickerDetail(body.Ticker).Select(e => e.IdTickerDetail).FirstOrDefault(),
                });

                await _service.SaveChangesAsync();
            }

        }

        [HttpDelete("{idUser}/{tickerName}")]
        public async Task DeleteWatchlist(string idUser, string tickerName)
        {
            var tickerId = await _service.GetTickerDetail(tickerName).Select(e => e.IdTickerDetail).FirstOrDefaultAsync();

            var watchlistEntry = await _service.GetWatchlists().Where(e => e.IdTickerDetail == tickerId && e.IdUser == idUser).FirstOrDefaultAsync();

            if (watchlistEntry == null)
                return;

            _service.Delete(watchlistEntry);

            await _service.SaveChangesAsync();
        }
    }
}
