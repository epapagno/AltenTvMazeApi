using AltenTvMazeModels;
using AltenTvMazeRepositories.Data;
using AltenTvMazeRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltenTvMazeRepositories
{
    public class ShowRepository : IShowRepository
    {
        private readonly TvMazeContext _context;

        public ShowRepository(TvMazeContext context)
        {
            _context = context;
        }

        public async Task<Show> GetShowByIdAsync(int id)
        {
            return await _context.Shows.FirstOrDefaultAsync(s => s.TvMazeId == id);
        }

        public async Task<IEnumerable<Show>> GetAllShowsAsync()
        {
            return await _context.Shows.ToListAsync();
        }

        public async Task AddShowAsync(Show show)
        {
            await _context.Shows.AddAsync(show);
        }

        public async Task UpdateShowAsync(Show show)
        {
            _context.Shows.Update(show);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
