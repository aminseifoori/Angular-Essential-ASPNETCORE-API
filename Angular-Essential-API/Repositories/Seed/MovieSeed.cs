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
                    Id = new Guid("06f158fe-277f-469b-adb3-878e3ec53e63"),
                    Name = "Face Off",
                    ReleaseDate = DateTime.Parse("1999/01/01")
                },
                new Movie
                {
                    Id = new Guid("c8a235b0-0764-49c5-b930-74ec0951c388"),
                    Name = "God Father 1",
                    ReleaseDate = DateTime.Parse("1960/01/01")
                },
                new Movie
                {
                    Id = new Guid("c40dea06-64c2-4e32-b1be-66de42062ec2"),
                    Name = "God Father 1",
                    ReleaseDate = DateTime.Parse("1970/01/01")
                },
                new Movie
                {
                    Id = new Guid("e01976fe-6f54-4197-bcb6-0e4c79b173a1"),
                    Name = "God Father 2",
                    ReleaseDate = DateTime.Parse("1980/01/01")
                },
                new Movie
                {
                    Id = new Guid("f135c973-e378-4a9d-820c-f1fe1c8b764a"),
                    Name = "God Father 3",
                    ReleaseDate = DateTime.Parse("1990/01/01")
                },
                new Movie
                {
                    Id = new Guid("c1deebaa-8e9e-4340-9b89-d63c451c0061"),
                    Name = "God Father 4",
                    ReleaseDate = DateTime.Parse("2000/01/01")
                }
                );
        }
    }
}
