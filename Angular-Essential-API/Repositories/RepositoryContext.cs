using Angular_Essential_API.Models;
using Angular_Essential_API.Repositories.Seed;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Angular_Essential_API.Repositories
{
    public class RepositoryContext : IdentityDbContext<User>
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Cost> Costs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new MovieSeed());
            builder.ApplyConfiguration(new CostSeed());

        }
    }
}
