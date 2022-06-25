using Microsoft.AspNetCore.Mvc;
using StocksPage.Server.Models;
using StocksPage.Server.Services;
using StocksPage.Shared.DTOs;
using StocksPage.Shared.DTOs.PolygonAPI;

namespace StocksPage.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TickerChartsController : ControllerBase
    {
        private readonly IStockService _service;
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public TickerChartsController(IStockService service, IConfiguration configuration, HttpClient httpClient)
        {
            _service = service;
            _configuration = configuration;
            _httpClient = httpClient;
        }

        [HttpGet("{tickerName}")]
        public async Task<IEnumerable<TickerChartGet>> GetTickerChart(string tickerName)
        {
            DateTime currentDate = DateTime.Now;
            DateTime fourMonthBeforeDate = DateTime.Now.AddMonths(-4);

            string now = currentDate.ToString("yyyy-MM-dd");
            string fourMonthBefore = fourMonthBeforeDate.ToString("yyyy-MM-dd");

            var newTickerChart = await _httpClient.GetFromJsonAsync<TickerChartPolygon>($"https://api.polygon.io/v2/aggs/ticker/{tickerName}/range/1/day/{fourMonthBefore}/{now}?adjusted=true&sort=asc&limit=120&apiKey=" + _configuration.GetValue<string>("PolygonAPIKey"));

            if (newTickerChart == null || !newTickerChart.results.Any())
                return Enumerable.Empty<TickerChartGet>();

            List<TickerChartGet> chart = new List<TickerChartGet>();

            var date = fourMonthBeforeDate;

            foreach (var point in newTickerChart.results)
            {
                chart.Add(new TickerChartGet
                {
                    Date = date,
                    Open = point.o,
                    High = point.h,
                    Low = point.l,
                    Close = point.c,
                    Volume = point.v
                });

                date = date.AddDays(1);
            }

            return chart;
        }
    }
}
