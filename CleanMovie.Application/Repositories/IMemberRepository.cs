using ClassMovie.Domain.DbModels;
using ClassMovie.Domain.Dtos;
using CleanMovie.Application.Repositories.Base;

namespace CleanMovie.Application.Repositories
{
    public interface IMemberRepository: IRepository<Member>
    {
        MovieListsDto GetMovieListByMember(int memberId);
    }
}
