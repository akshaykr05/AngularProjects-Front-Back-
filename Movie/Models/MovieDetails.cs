using System.ComponentModel.DataAnnotations;

namespace Movie.Models
{
    public class MovieDetails
    {
        [Key]
        public int movieId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string release_date { get; set; }
        public string poster_path { get; set; }
        public string comment { get; set; }

    }
}
