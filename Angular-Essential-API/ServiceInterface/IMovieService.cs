using Angular_Essential_API.Dtos;
using Angular_Essential_API.Models;

namespace Angular_Essential_API.ServiceInterface
{
    public interface IMovieService
    {
        Task<List<Movie>> GetAllMoviesAsync();
        Task<Movie> GetMovieAsync(Guid id);
        Task<Movie> CreateMovie(CreateMovieDto movie);
        Task DeleteMovie(Guid id);
        Task UpdateMovie(UpdateMovieDto movie, Guid id);
    }
}
