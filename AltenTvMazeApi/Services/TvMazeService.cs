using AltenTvMazeApi.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AltenTvMazeApi.Services
{
    public class TvMazeService
    {
        private readonly HttpClient _httpClient;

        public TvMazeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Show> GetShowByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Show>($"https://api.tvmaze.com/shows/{id}");
        }

        public async Task<IEnumerable<Show>> GetAllShowsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Show>>("https://api.tvmaze.com/shows");
        }
    }
}
