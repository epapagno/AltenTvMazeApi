using AltenTvMazeModels;

namespace AltenTvMazeRepositories.Interfaces
{
    public interface IShowRepository
    {
        Task<Show> GetShowByIdAsync(int id);
        Task<IEnumerable<Show>> GetAllShowsAsync();
        Task AddShowAsync(Show show);
        Task UpdateShowAsync(Show show);
        Task SaveChangesAsync();
    }
}
