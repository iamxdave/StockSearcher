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

                if (newTickerDetail == null)
                    return null;
                
                TickerDetail td;

                td = new TickerDetail
                {
                    Ticker = newTickerDetail.results.ticker,
                    Name = newTickerDetail.results.name,
                    SicDescription = newTickerDetail.results.sic_description,
                    Country = newTickerDetail.results.locale,
                    Currency = newTickerDetail.results.currency_name,
                    Cik = newTickerDetail.results.cik,
                    Description = newTickerDetail.results.description,
                    TotalEmployees = newTickerDetail.results.total_employees,
                    Homepage = newTickerDetail.results.homepage_url,
                };

                if (newTickerDetail.results.branding != null)
                {
                    td.LogoUrl = newTickerDetail.results.branding.logo_url;
                }

                await _service.CreateAsync(td);
                await _service.SaveChangesAsync();

                return new TickerDetailGet
                {
                    LogoUrl = td.LogoUrl == null ? null : td.LogoUrl + "?apiKey=" + _configuration.GetValue<string>("PolygonAPIKey"),
                    Ticker = td.Ticker,
                    Name = td.Name,
                    SicDescription = td.SicDescription,
                    Country = td.Country,
                    Currency = td.Currency,
                    Cik = td.Cik,
                    Description = td.Description,
                    TotalEmployees = td.TotalEmployees,
                    Homepage = td.Homepage
                };
            }


            return _service.GetTickerDetail(tickerName).Select(e => new TickerDetailGet
            {
                LogoUrl = e.LogoUrl == null ? null : e.LogoUrl + "?apiKey=" + _configuration.GetValue<string>("PolygonAPIKey"),
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

