﻿using System.ComponentModel.DataAnnotations;

namespace Angular_Essential_API.Models
{
    public class Movie
    {
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public virtual ICollection<Cost> Costs { get; set; }
    }
}
