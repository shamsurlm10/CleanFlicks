using CleanMovie.Application.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace CleanMovie.Infrastructure.Repositories.Base
{
    public abstract class EfRepository<T> : IRepository<T> where T : class
    {
        private readonly MovieDbContext _db;

        protected EfRepository(MovieDbContext db)
        {
            _db = db;
        }

        public async Task<bool> AddAsync(T Entity)
        {
            _db.Set<T>().Add(Entity);
            return await _db.SaveChangesAsync()>0;
        }

        public virtual async Task<T> FindByIdAsync(int Id)
        {
            return await _db.Set<T>().FindAsync(Id);
        }

        public virtual async Task<IReadOnlyList<T>> GetALlAsync()
        {
            return await _db.Set<T>().AsNoTracking().ToListAsync();
        }
    }
}
