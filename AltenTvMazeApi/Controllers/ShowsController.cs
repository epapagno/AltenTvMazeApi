using AltenTvMazeModels;
using AltenTvMazeServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AltenTvMazeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShowsController : ControllerBase
    {
        private readonly ShowService _showService;

        public ShowsController(ShowService showService)
        {
            _showService = showService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetShow(int id)
        {
            var show = await _showService.GetShowByIdAsync(id);
            if (show == null)
            {
                return NotFound();
            }
            return Ok(show);
        }

        [HttpGet]
        public async Task<IEnumerable<Show>> GetAllShows()
        {
            return await _showService.GetAllShowsAsync();
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateShows()
        {
            await _showService.UpdateDatabaseAsync();
            return NoContent();
        }
    }
}
