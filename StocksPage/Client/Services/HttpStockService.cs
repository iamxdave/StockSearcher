using System.Net.Http.Json;
using StocksPage.Shared.DTOs;

namespace StocksPage.Client.Services
{
    public class HttpStockService : IHttpStockService
    {
        private readonly HttpClient _httpClient;
        public HttpStockService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<TickerDetailGet?> GetTickerDetail(string tickerName)
        {
            return await _httpClient.GetFromJsonAsync<TickerDetailGet>($"api/TickerDetails/{tickerName}");
        }
        public async Task<IEnumerable<WatchlistTickerDetailGet>?> GetTickerDetailsFromWatchlist(int idWatchlist)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<WatchlistTickerDetailGet>>($"api/WatchlistTickerDetails/{idWatchlist}");
        }
        public async Task<IEnumerable<TickerNameGet>?> GetTickerNames()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<TickerNameGet>>("api/TickerNames");
        }
        public async Task<IEnumerable<TickerChartGet>?> GetTickerChart(string tickerName)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<TickerChartGet>>($"api/TickerCharts/{tickerName}");
        }
        public async Task DeleteDetailFromWatchlist(string tickerName)
        {
            await _httpClient.DeleteAsync($"api/WatchlistTickerDetails/{tickerName}");
        }
    }
}
