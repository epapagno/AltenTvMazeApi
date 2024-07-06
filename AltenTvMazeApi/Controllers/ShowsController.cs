using AltenTvMazeApi.Models;
using AltenTvMazeApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AltenTvMazeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShowsController : ControllerBase
    {
        private readonly TvMazeService _tvMazeService;

        public ShowsController(TvMazeService tvMazeService)
        {
            _tvMazeService = tvMazeService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetShow(int id)
        {
            var show = await _tvMazeService.GetShowByIdAsync(id);
            if (show == null)
            {
                return NotFound();
            }
            return Ok(show);
        }

        [HttpGet]
        public async Task<IEnumerable<Show>> GetAllShows()
        {
            return await _tvMazeService.GetAllShowsAsync();
        }
    }
}
