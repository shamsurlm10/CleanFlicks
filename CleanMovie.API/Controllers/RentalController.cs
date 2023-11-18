using AutoMapper;
using ClassMovie.Domain.DbModels;
using ClassMovie.Domain.Dtos;
using CleanMovie.Application.Interfaces;
using CleanMovie.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CleanMovie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalController : ControllerBase
    {
        private readonly IRentalService _rentalService;
        private readonly IMapper _mapper;

        public RentalController(IRentalService rentalService, IMapper mapper)
        {
            _rentalService = rentalService;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult> CreateRental([FromBody] RentalDto rental)
        {
            var mapper = _mapper.Map<Rental>(rental);
            var newRental = await _rentalService.AddAsync(mapper);
            return Ok(newRental);
        }
        [HttpGet]
        public async Task<ActionResult<List<Rental>>> GetRentals()
        {
            var rentals = await _rentalService.GetALlAsync();
            var mapper = _mapper.Map<Rental>(rentals);
            return Ok(mapper);
        }
    }
}
