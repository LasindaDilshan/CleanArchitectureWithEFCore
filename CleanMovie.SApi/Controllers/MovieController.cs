using CleanMovie.Application;
using CleanMovieDomain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanMovie.SApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService service)
        {
            _movieService = service;
        }
        // GET: api/<MovieController>
        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            var movieList = _movieService.GetAllMovies();

            return Ok(movieList);
        }
        [HttpPost]
        public ActionResult<Movie> Post(Movie movie)
        {
            var movies = _movieService.CreateMovie(movie);
            return Ok(movies);
        }
    }
}
