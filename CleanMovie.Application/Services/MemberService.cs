using ClassMovie.Domain.DbModels;
using CleanMovie.Application.Interfaces;
using CleanMovie.Application.Repositories;
using CleanMovie.Application.Repositories.Base;
using CleanMovie.Application.Services.Base;

namespace CleanMovie.Application.Services
{
    public class MemberService : Manager<Member>, IMemberService
    {
        private readonly IMemberRepository _repo;

        public MemberService(IMemberRepository repo) : base(repo)
        {
            _repo = repo;
        }
    }
}
