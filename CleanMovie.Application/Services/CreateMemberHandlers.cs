using AutoMapper;
using MediatR;
using ClassMovie.Domain.Dtos;
using CleanMovie.Application.Interfaces;
using AbxERP.Infrastructure.Models;
using ClassMovie.Domain.DbModels;

namespace CleanMovie.Application.Services
{
    public class CreateMemberCommand: IRequest<ResponseResult>
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int RentalId { get; set; }

        //public MemberDto Member { get; set; }
    }
    public class CreateMemberHandlers : IRequestHandler<CreateMemberCommand, ResponseResult>
    {
        private readonly IMapper _mapper;
        private readonly IMemberService _memberService;

        public CreateMemberHandlers(IMapper mapper, IMemberService memberService)
        {
            _mapper = mapper;
            _memberService = memberService;
        }

        public async Task<ResponseResult> Handle(CreateMemberCommand request, CancellationToken cancellationToken)
        {
            var mapper = _mapper.Map<Member>(request);
            await _memberService.AddAsync(mapper);
            return new ResponseResult("Created");
        }
    }
}
