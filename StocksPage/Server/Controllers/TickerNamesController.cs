using System.Transactions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StocksPage.Server.Models;
using StocksPage.Server.Services;
using StocksPage.Shared.DTOs;
using StocksPage.Shared.DTOs.PolygonAPI;

namespace StocksPage.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TickerNamesController : ControllerBase
    {
        private readonly IStockService _service;
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public TickerNamesController(IStockService service, IConfiguration configuration, HttpClient httpClient)
        {
            _service = service;
            _configuration = configuration;
            _httpClient = httpClient;
        }

        [HttpGet]
        public async Task<IEnumerable<TickerNameGet>> GetTickerNames()
        {
            var tickers = _service.GetTickerNames();

            if (tickers == null || !tickers.Any())
            {
                var newTickers = await _httpClient.GetFromJsonAsync<TickerNamePolygon>("https://api.polygon.io/v3/reference/tickers?market=stocks&active=true&sort=ticker&order=asc&limit=1000&apiKey=" + _configuration.GetValue<string>("PolygonAPIKey"));

                using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {

                    while (!(newTickers.next_url == null))
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            foreach (var tn in newTickers.results)
                            {
                                var ticker = _service.GetTickerName(tn.ticker);
                                if (ticker == null || !ticker.Any())
                                    await _service.CreateAsync(new TickerName
                                    {
                                        Ticker = tn.ticker,
                                        Name = tn.name
                                    });
                            }
                            newTickers = await _httpClient.GetFromJsonAsync<TickerNamePolygon>(newTickers.next_url + "&apiKey=" + _configuration.GetValue<string>("PolygonAPIKey"));
                        }
                        await _service.SaveChangesAsync();
                        await Task.Delay(61000);

                    }

                    scope.Complete();
                }

            }

            return _service.GetTickerNames().Select(e => new TickerNameGet
            {
                Name = e.Name,
                Ticker = e.Ticker
            }).ToList();
        }
    }
}
