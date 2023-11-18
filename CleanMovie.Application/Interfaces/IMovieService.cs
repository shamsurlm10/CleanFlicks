using ClassMovie.Domain.DbModels;
using CleanMovie.Application.Interfaces.Base;

namespace CleanMovie.Application.Interfaces
{
    public interface IMovieService: IManager<Movie>
    {
    }
}
