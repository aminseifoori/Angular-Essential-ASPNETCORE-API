using Angular_Essential_API.Models;
using Angular_Essential_API.Repositories;
using Angular_Essential_API.ServiceInterface;
using Microsoft.EntityFrameworkCore;

namespace Angular_Essential_API.Service
{
    public class MovieServices : IMovieService
    {
        private readonly RepositoryContext context;

        public MovieServices(RepositoryContext context)
        {
            this.context = context;
        }
        public void CreateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public void DeleteMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Movie>> GetAllMoviesAsync()
        {
            var movies = await context.Movies
                .AsNoTracking()
                .ToListAsync();
            return movies;
        }

        public async Task<Movie> GetMovieAsync(Guid id)
        {
            var movie = await context.Movies.Include(x=> x.Costs).FirstOrDefaultAsync(x => x.Id == id);
            return movie;
        }

    }
}
