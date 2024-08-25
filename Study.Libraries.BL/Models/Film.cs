
using Study.Libraries.BL.Models.Enums;

namespace Study.Libraries.BL.Models
{
    public class Film
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Genres Genre { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public double ImdbRating { get; set; }
    }
}
