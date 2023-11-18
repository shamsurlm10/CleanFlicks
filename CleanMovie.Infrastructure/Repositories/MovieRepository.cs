using ClassMovie.Domain.DbModels;
using CleanMovie.Application.Repositories;
using CleanMovie.Infrastructure.Repositories.Base;

namespace CleanMovie.Infrastructure.Repositories
{
    public class MovieRepository : EfRepository<Movie>, IMovieRepository
    {
        private readonly MovieDbContext _db;

        public MovieRepository(MovieDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
