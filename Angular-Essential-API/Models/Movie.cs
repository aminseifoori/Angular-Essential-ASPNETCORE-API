using System.ComponentModel.DataAnnotations;

namespace Angular_Essential_API.Models
{
    public class Movie
    {
        [Required]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
