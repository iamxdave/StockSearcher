using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StocksPage.Server.Models;
using StocksPage.Server.Services;
using StocksPage.Shared.DTOs;
using StocksPage.Shared.DTOs.PolygonAPI;

namespace StocksPage.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public NewsController(IConfiguration configuration, HttpClient httpClient)
        {
            _configuration = configuration;
            _httpClient = httpClient;
        }

        [HttpGet("{tickerName}")]
        public async Task<IEnumerable<TickerNewsGet>>? GetTickerNews(string tickerName)
        {
            var newTickerNews = await _httpClient.GetFromJsonAsync<TickerNewsPolygon>($"https://api.polygon.io/v2/reference/news?ticker={tickerName}&limit=5&sort=published_utc&apiKey=" + _configuration.GetValue<string>("PolygonAPIKey"));

            if (newTickerNews.results == null)
                return Enumerable.Empty<TickerNewsGet>();

            return newTickerNews.results.Select(e => new TickerNewsGet
            {
                Title = e.title,
                PageName = e.publisher.name,
                Created = e.published_utc
            });
        }
    }
}
