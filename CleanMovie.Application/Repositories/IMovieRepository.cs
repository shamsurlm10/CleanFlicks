using ClassMovie.Domain.DbModels;
using CleanMovie.Application.Repositories.Base;

namespace CleanMovie.Application.Repositories
{
    public interface IMovieRepository:IRepository<Movie>
    {
    }
}
