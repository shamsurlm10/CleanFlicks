using ClassMovie.Domain;
using CleanMovie.Application;
using Microsoft.AspNetCore.Mvc;

namespace CleanMovie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        [HttpPost]
        public ActionResult<Movie> CreateMovie(Movie movie)
        {
            var Movie= _movieService.CreateMovies(movie);
            return Ok(Movie);
        }
        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            var movies = _movieService.GetAllMovies();
            return Ok(movies);
        }

    }
}
