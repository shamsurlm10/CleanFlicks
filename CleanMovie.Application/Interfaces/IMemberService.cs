using ClassMovie.Domain.DbModels;
using ClassMovie.Domain.Dtos;
using CleanMovie.Application.Interfaces.Base;

namespace CleanMovie.Application.Interfaces
{
    public interface IMemberService : IManager<Member>
    {
        MovieListsDto GetMovieListByMember(int memberId);
    }
}
