using AutoMapper;
using ClassMovie.Domain.DbModels;
using ClassMovie.Domain.Dtos;
using CleanMovie.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanMovie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;

        public MoviesController(IMovieService movieService, IMapper mapper)
        {
            _movieService = movieService;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult> CreateMovie([FromBody] MovieDto movie)
        {
            var mapper = _mapper.Map<Movie>(movie);
            var newMovie = await _movieService.AddAsync(mapper);
            return Ok(newMovie);
        }
        [HttpGet]
        public async Task<ActionResult<List<MovieListDto>>> GetMovies()
        {
            var movie = await _movieService.GetALlAsync();
            var mapper = _mapper.Map<MovieListDto>(movie);
            return Ok(mapper);
        }

    }
}
