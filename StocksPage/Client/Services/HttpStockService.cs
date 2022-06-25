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
        public async Task<IEnumerable<WatchlistGet>?> GetTickersFromWatchlist(string idUser)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<WatchlistGet>>($"api/Watchlists/{idUser}");
        }
        public async Task<IEnumerable<TickerNameGet>?> GetTickerNames()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<TickerNameGet>>("api/TickerNames");
        }
        public async Task<IEnumerable<TickerChartGet>?> GetTickerChart(string tickerName)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<TickerChartGet>>($"api/TickerCharts/{tickerName}");
        }
        public async Task<IEnumerable<TickerNewsGet>?> GetTickerNews(string tickerName)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<TickerNewsGet>>($"api/News/{tickerName}");
        }
        public async Task AddTickerToWatchlist(TickerDetailGet ticker, string idUser)
        {
            await _httpClient.PostAsJsonAsync($"api/Watchlists/{idUser}", ticker);
        }
        public async Task DeleteTickerFromWatchlist(string tickerName, string idUser)
        {
            await _httpClient.DeleteAsync($"api/Watchlists/{idUser}/{tickerName}");
        }
    }
}
