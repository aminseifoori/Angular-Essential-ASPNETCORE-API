using Angular_Essential_API.Dtos;
using Angular_Essential_API.Models;
using Angular_Essential_API.Repositories;
using Angular_Essential_API.ServiceInterface;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Angular_Essential_API.Service
{
    public class MovieServices : IMovieService
    {
        private readonly RepositoryContext context;
        private readonly IMapper mapper;

        public MovieServices(RepositoryContext context, IMapper _mapper)
        {
            this.context = context;
            mapper = _mapper;
        }
        public async Task<Movie> CreateMovie(CreateMovieDto movie)
        {
            Movie newMovie = mapper.Map<Movie>(movie);
            await context.Movies.AddAsync(newMovie);
            await context.SaveChangesAsync();
            return newMovie;
        }

        public async Task DeleteMovie(Guid id)
        {
            var movie = await context.Movies.FindAsync(id);
            context.Movies.Remove(movie);
            await context.SaveChangesAsync();
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

        public async Task UpdateMovie(UpdateMovieDto movie, Guid id)
        {
            var existMovie = await context.Movies.FindAsync(id);
            mapper.Map(movie, existMovie);
            await context.SaveChangesAsync();
        }


    }
}
