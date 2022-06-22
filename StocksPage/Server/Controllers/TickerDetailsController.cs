using Microsoft.AspNetCore.Mvc;
using StocksPage.Server.Models;
using StocksPage.Server.Services;
using StocksPage.Shared.DTOs;
using StocksPage.Shared.DTOs.PolygonAPI;

namespace StocksPage.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TickerDetailsController : ControllerBase
    {
        private readonly IStockService _service;
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public TickerDetailsController(IStockService service, IConfiguration configuration, HttpClient httpClient)
        {
            _service = service;
            _configuration = configuration;
            _httpClient = httpClient;
        }

        [HttpGet("{tickerName}")]
        public async Task<TickerDetailGet?> GetTickerDetail(string tickerName)
        {
            var tickerDetail = _service.GetTickerDetail(tickerName);

            if (tickerDetail == null || !tickerDetail.Any())
            {
                var newTickerDetail = await _httpClient.GetFromJsonAsync<TickerDetailPolygon>($"https://api.polygon.io/v3/reference/tickers/{tickerName}?apiKey=" + _configuration.GetValue<string>("PolygonAPIKey"));

                await _service.CreateAsync(new TickerDetail
                {
                    LogoUrl = newTickerDetail.results.branding.logo_url,
                    Ticker = newTickerDetail.results.ticker,
                    Name = newTickerDetail.results.name,
                    SicDescription = newTickerDetail.results.sic_description,
                    Country = newTickerDetail.results.locale,
                    Currency = newTickerDetail.results.currency_name,
                    Cik = newTickerDetail.results.cik,
                    Description = newTickerDetail.results.description,
                    TotalEmployees = newTickerDetail.results.total_employees,
                    Homepage = newTickerDetail.results.homepage_url,
                });
                await _service.SaveChangesAsync();
            }

            return _service.GetTickerDetail(tickerName).Select(e => new TickerDetailGet
            {
                LogoUrl = e.LogoUrl,
                Ticker = e.Ticker,
                Name = e.Name,
                SicDescription = e.SicDescription,
                Country = e.Country,
                Currency = e.Currency,
                Cik = e.Cik,
                Description = e.Description,
                TotalEmployees = e.TotalEmployees,
                Homepage = e.Homepage
            }).FirstOrDefault();
        }
    }
}

