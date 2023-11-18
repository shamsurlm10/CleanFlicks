using AutoMapper;
using ClassMovie.Domain.DbModels;
using ClassMovie.Domain.Dtos;
using CleanMovie.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanMovie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _memberService;
        private readonly IMapper _mapper;

        public MemberController(IMemberService memberService, IMapper mapper)
        {
            _memberService = memberService;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult> CreateMember([FromBody]MemberDto member)
        {
            var mapper = _mapper.Map<Member>(member);
            var newMember = await _memberService.AddAsync(mapper);
            return Ok(newMember);
        }
        [HttpGet]
        public async Task<ActionResult<List<Member>>> GetMembers()
        {
            var members = await _memberService.GetALlAsync();
            var mapper = _mapper.Map<Member>(members);
            return Ok(mapper);
        }

    }
}
