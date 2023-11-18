using ClassMovie.Domain;

namespace CleanMovie.Application
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
        Movie CreateMovies(Movie movie);
    }
}
