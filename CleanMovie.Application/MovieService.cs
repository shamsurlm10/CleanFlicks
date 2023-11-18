using ClassMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Movie CreateMovies(Movie movie)
        {
            _movieRepository.CreateMovies(movie);
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            var movies = _movieRepository.GetALlMovies();

            return movies;
        }
    }
}
