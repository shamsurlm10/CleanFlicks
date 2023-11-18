using ClassMovie.Domain.DbModels;
using CleanMovie.Application.Repositories;
using CleanMovie.Infrastructure.Repositories.Base;

namespace CleanMovie.Infrastructure.Repositories
{
    public class MemeberRepository : EfRepository<Member>, IMemberRepository
    {
        private readonly MovieDbContext _db;

        public MemeberRepository(MovieDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
