using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Angular_Essential_API.Models
{
    public class Cost
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public Guid MovieID { get; set; }
        [ForeignKey("MovieID")]
        public virtual Movie Movie { get; set; }
    }
}
