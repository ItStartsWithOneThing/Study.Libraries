
using Study.Libraries.BL.Models;

namespace Study.Libraries.BL.Services.FilmService
{
    public interface IFilmService
    {
        public Task<Guid> AddFilm(Film newFilm);
        public Task<List<Film>> GetAllFilms();
        public Task<Film> GetFilm(Guid id);
        public Task<bool> DeleteFilm(Guid id);
    }
}
