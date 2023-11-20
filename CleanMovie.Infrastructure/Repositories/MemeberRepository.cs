using ClassMovie.Domain.DbModels;
using ClassMovie.Domain.Dtos;
using CleanMovie.Application.Repositories;
using CleanMovie.Infrastructure.Repositories.Base;

namespace CleanMovie.Infrastructure.Repositories
{
    public class MemeberRepository : EfRepository<Member>, IMemberRepository
    {
        private readonly MovieDbContext _db;

        public MemeberRepository(MovieDbContext db) : base(db)
        {
            _db = db;
        }

        public MovieListsDto GetMovieListByMember(int memberId)
        {
            var member= (from m in _db.Members
                         where m.MemberId == memberId
                         select new MovieListsDto
                         {
                             MemberId = m.MemberId,
                             Name = m.Name,
                             Email = m.Email
                         }).SingleOrDefault();
            member.Movies = (from m in _db.Members
                             join r in _db.Rentals on m.RentalId equals r.RentalId into rentalGroup
                             from rental in rentalGroup.DefaultIfEmpty()
                             join mr in _db.MovieRentals on rental.RentalId equals mr.RentalId into movieRentalGroup
                             from movieRental in movieRentalGroup.DefaultIfEmpty()
                             join mo in _db.Movies on movieRental.MovieId equals mo.MovieId into movieGroup
                             from movie in movieGroup.DefaultIfEmpty()
                             where m.MemberId == memberId
                             select new MovieDto
                             {
                                 MovieName = movie != null ? movie.MovieName : null,
                                 RentalCost = movie != null ? (decimal)movie.RentalCost : 0m,
                                 RentalDuration = movie != null ? (int)movie.RentalDuration : 0,
                             }).ToList();



            return member;
        }
    }
}
