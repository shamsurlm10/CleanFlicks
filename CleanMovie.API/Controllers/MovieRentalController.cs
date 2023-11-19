using AutoMapper;
using ClassMovie.Domain.DbModels;
using ClassMovie.Domain.Dtos;
using CleanMovie.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanMovie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieRentalController : ControllerBase
    {
        private readonly IMovieRentalService _movieRentalService;
        private readonly IMapper _mapper;

        public MovieRentalController(IMovieRentalService movieRentalService, IMapper mapper)
        {
            _movieRentalService = movieRentalService ?? throw new ArgumentNullException(nameof(movieRentalService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _movieRentalService = movieRentalService;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult> CreateMovieRental([FromBody] MovieRentalDto movieRental)
        {
            var mapper = _mapper.Map<MovieRental>(movieRental);
            if (mapper == null)
            {
                return BadRequest();
            }
            var newMovieRental = await _movieRentalService.AddAsync(mapper);

            return Ok(newMovieRental);
        }
    }
}
