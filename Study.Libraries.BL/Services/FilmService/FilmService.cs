
using Study.Libraries.BL.Models;
using Study.Libraries.BL.Models.Enums;

namespace Study.Libraries.BL.Services.FilmService
{
    public class FilmService : IFilmService
    {
        private List<Film> Films = new List<Film>()
        {
            new Film()
            {
                Id = Guid.NewGuid(),
                Name = "Terminator",
                Genre = Genres.Action,
                Year = 1984,
                Description = "Good movie with Arnold",
                ImdbRating = 8.1
            }
        };

        public Task<Guid> AddFilm(Film newFilm)
        {
            Films.Add(newFilm);

            return Task.FromResult(newFilm.Id);
        }

        public Task<bool> DeleteFilm(Guid id)
        {
            var filmToRemove = Films.FirstOrDefault(f => f.Id == id);

            return Task.FromResult(Films.Remove(filmToRemove!));
        }

        public Task<List<Film>> GetAllFilms()
        {
            return Task.FromResult(Films);
        }

        public Task<Film> GetFilm(Guid id)
        {
            return Task.FromResult(Films.FirstOrDefault(f => f.Id == id)!);
        }
    }
}
