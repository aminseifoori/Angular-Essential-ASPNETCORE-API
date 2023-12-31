﻿using System.ComponentModel.DataAnnotations;

namespace Angular_Essential_API.Dtos
{
    public class MovieManipulationDto
    {
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
