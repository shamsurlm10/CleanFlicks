using ClassMovie.Domain.DbModels;
using CleanMovie.Application.Interfaces;
using CleanMovie.Application.Repositories;
using CleanMovie.Application.Repositories.Base;
using CleanMovie.Application.Services.Base;

namespace CleanMovie.Application.Services
{
    public class MovieService : Manager<Movie>, IMovieService
    {
        private readonly IMovieRepository _repo;

        public MovieService(IMovieRepository repo) : base(repo)
        {
            _repo = repo;
        }
    }
}
