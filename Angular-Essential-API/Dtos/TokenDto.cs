using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular_Essential_API.Dtos
{
    public record TokenDto
    {
        public string AccessToken { get; init; }
        public string RefreshToken { get; init; }
    }
}
