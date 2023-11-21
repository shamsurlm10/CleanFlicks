namespace CleanMovie.Application.Repositories.Base
{
    public interface IRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetALlAsync();
        Task<bool> AddAsync(T Entity);
        Task<T> FindByIdAsync(int id);
    }
}
