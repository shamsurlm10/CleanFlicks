namespace CleanMovie.Application.Interfaces.Base
{
    public interface IManager<T> where T : class
    {
        Task<IReadOnlyList<T>> GetALlAsync();
        Task<bool> AddAsync(T entity);
    }
}
