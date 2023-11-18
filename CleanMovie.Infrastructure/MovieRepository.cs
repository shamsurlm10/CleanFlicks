using ClassMovie.Domain;
using CleanMovie.Application;

namespace CleanMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDbContext _db;
        public MovieRepository(MovieDbContext db)
        {
            _db = db;   
        }
        public Movie CreateMovies(Movie movie)
        {
            _db.Movies.Add(movie);
            _db.SaveChanges();
            return movie;
        }

        public List<Movie> GetALlMovies()
        {
            return _db.Movies.ToList();
        }
    }
}
