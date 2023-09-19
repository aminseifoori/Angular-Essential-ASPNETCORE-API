using Angular_Essential_API.Models;

namespace Angular_Essential_API.ServiceInterface
{
    public interface IMovieService
    {
        Task<List<Movie>> GetAllMoviesAsync();
        Task<Movie> GetMovieAsync(Guid id);
        void CreateMovie(Movie movie);
        void DeleteMovie(Movie movie);
    }
}
