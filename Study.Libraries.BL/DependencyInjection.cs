
using Microsoft.Extensions.DependencyInjection;
using Study.Libraries.BL.Services.FilmService;

namespace Study.Libraries.BL
{
    public static class DependencyInjection
    {
        public static void AddBLServices(this IServiceCollection services)
        {
            services.AddScoped<IFilmService, FilmService>();
        }
    }
}
