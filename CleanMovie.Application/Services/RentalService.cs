using ClassMovie.Domain.DbModels;
using CleanMovie.Application.Interfaces;
using CleanMovie.Application.Repositories;
using CleanMovie.Application.Repositories.Base;
using CleanMovie.Application.Services.Base;

namespace CleanMovie.Application.Services
{
    public class RentalService : Manager<Rental>, IRentalService

    {
        private readonly IRentalRepository _repo;

        public RentalService(IRentalRepository repo) : base(repo)
        {
            _repo = repo;
        }
    }
}
