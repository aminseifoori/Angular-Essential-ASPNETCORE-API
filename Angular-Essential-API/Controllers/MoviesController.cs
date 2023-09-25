using Angular_Essential_API.Dtos;
using Angular_Essential_API.ServiceInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Angular_Essential_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService service;

        public MoviesController(IMovieService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var movies = await service.GetAllMoviesAsync();
            return Ok(movies);
        }

        [HttpGet("{id:guid}", Name = "MovieById")]
        public async Task<IActionResult> Get(Guid id)
        {
            var movies = await service.GetMovieAsync(id);
            return Ok(movies);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie([FromBody] CreateMovieDto movie)
        {
            if(ModelState.IsValid)
            {
                var createMovie = await service.CreateMovie(movie);
                return Ok(createMovie);
            }
            return new UnprocessableEntityObjectResult(ModelState);
        }
    }
}
