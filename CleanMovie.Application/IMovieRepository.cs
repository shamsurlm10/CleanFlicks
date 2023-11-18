using ClassMovie.Domain;

namespace CleanMovie.Application
{
    public interface IMovieRepository
    {
        List<Movie> GetALlMovies();
        Movie CreateMovies(Movie movie);
    }
}
