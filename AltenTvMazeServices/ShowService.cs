using AltenTvMazeModels;
using AltenTvMazeRepositories.Interfaces;
using System.Net.Http.Json;

namespace AltenTvMazeServices
{
    public class ShowService
    {
        private readonly HttpClient _httpClient;
        private readonly IShowRepository _showRepository;

        public ShowService(HttpClient httpClient, IShowRepository showRepository)
        {
            _httpClient = httpClient;
            _showRepository = showRepository;
        }

        public async Task<Show> GetShowByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Show>($"https://api.tvmaze.com/shows/{id}");
        }

        public async Task<IEnumerable<Show>> GetAllShowsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Show>>("https://api.tvmaze.com/shows");
        }

        public async Task UpdateDatabaseAsync()
        {
            var shows = await GetAllShowsAsync();
            foreach (var show in shows)
            {
                var existingShow = await _showRepository.GetShowByIdAsync(show.Id);
                if (existingShow == null)
                {
                    show.TvMazeId = show.Id;
                    await _showRepository.AddShowAsync(show);
                }
                else
                {
                    existingShow.Name = show.Name;
                    existingShow.Language = show.Language;
                    existingShow.Premiered = show.Premiered;
                    existingShow.OfficialSite = show.OfficialSite;
                    existingShow.Summary = show.Summary;
                    await _showRepository.UpdateShowAsync(existingShow);
                }
            }
            await _showRepository.SaveChangesAsync();
        }
    }
}
