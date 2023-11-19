using ClassMovie.Domain.DbModels;
using CleanMovie.Application.Interfaces;
using CleanMovie.Application.Repositories;
using CleanMovie.Application.Repositories.Base;

namespace CleanMovie.Application.Services.Base
{
    public class MovieRentalService : Manager<MovieRental>, IMovieRentalService
    {
        private readonly IMovieRentalRepository _repo;

        public MovieRentalService(IMovieRentalRepository repo) : base(repo)
        {
            _repo = repo;
        }
    }
}
