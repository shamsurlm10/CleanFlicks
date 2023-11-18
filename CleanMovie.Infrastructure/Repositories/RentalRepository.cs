using ClassMovie.Domain.DbModels;
using CleanMovie.Application.Repositories;
using CleanMovie.Infrastructure.Repositories.Base;

namespace CleanMovie.Infrastructure.Repositories
{
    public class RentalRepository : EfRepository<Rental>, IRentalRepository
    {
        private readonly MovieDbContext _db;

        public RentalRepository(MovieDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
