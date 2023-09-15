using Angular_Essential_API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Angular_Essential_API.Repositories.Seed
{
    public class MovieSeed : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasData(
                new Movie
                {
                    Name = "Face Off",
                    ReleaseDate = DateTime.Parse("1999/01/01")
                },
                new Movie
                {

                    Name = "God Father 1",
                    ReleaseDate = DateTime.Parse("1960/01/01")
                },
                new Movie
                {
                    Name = "God Father 1",
                    ReleaseDate = DateTime.Parse("1970/01/01")
                },
                new Movie
                {
                    Name = "God Father 2",
                    ReleaseDate = DateTime.Parse("1980/01/01")
                },
                new Movie
                {
                    Name = "God Father 3",
                    ReleaseDate = DateTime.Parse("1990/01/01")
                },
                new Movie
                {
                    Name = "God Father 4",
                    ReleaseDate = DateTime.Parse("2000/01/01")
                }
                ); ;
        }
    }
}
