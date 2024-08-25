
using Microsoft.AspNetCore.Mvc;
using Study.Libraries.BL.Models;
using Study.Libraries.BL.Services.FilmService;
using System.Net;
using System.Text;

namespace Study.Libraries.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmController : ControllerBase
    {
        private readonly ILogger<FilmController> _logger;
        private readonly IFilmService _filmService;

        public FilmController(
            ILogger<FilmController> logger,
            IFilmService filmService)
        {
            _logger = logger;
            _filmService = filmService;
        }

        /// <summary>
        /// Get all existing films
        /// </summary>
        /// /// <remarks>
        /// Possible Genre enum values:
        /// 
        ///     status: Action = 0, Drama = 1, Comedy = 2, Fantasy = 3
        ///
        /// </remarks>
        /// <returns>Array of Films</returns>
        [HttpGet(Name = "GetAllFilms")]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(IEnumerable<Film>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var result = await _filmService.GetAllFilms();

            StringBuilder logMessage = new StringBuilder();

            foreach(var film in result)
            {
                logMessage.AppendLine(film.Name + $" Id: {film.Id}");
            }

            _logger.LogInformation(logMessage.ToString());

            return Ok(result);
        }
    }
}
