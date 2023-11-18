using CleanMovie.Application.Interfaces.Base;
using CleanMovie.Application.Repositories.Base;

namespace CleanMovie.Application.Services.Base
{
    public abstract class Manager<T> : IManager<T> where T : class
    {
        private readonly IRepository<T> _repo;

        public Manager(IRepository<T> repo)
        {
            _repo = repo;
        }
        public async Task<bool> AddAsync(T entity)
        {
            return await _repo.AddAsync(entity);
        }

        public async Task<IReadOnlyList<T>> GetALlAsync()
        {
            return await _repo.GetALlAsync();
        }
    }
}
