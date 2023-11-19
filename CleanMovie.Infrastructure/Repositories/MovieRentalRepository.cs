using ClassMovie.Domain.DbModels;
using CleanMovie.Application.Repositories;
using CleanMovie.Infrastructure.Repositories.Base;

namespace CleanMovie.Infrastructure.Repositories
{
    public class MovieRentalRepository : EfRepository<MovieRental>, IMovieRentalRepository
    {
        private readonly MovieDbContext _db;

        public MovieRentalRepository(MovieDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
