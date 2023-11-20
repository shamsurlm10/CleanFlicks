using AutoMapper;
using ClassMovie.Domain.DbModels;
using ClassMovie.Domain.Dtos;
using CleanMovie.API.Controllers.Base;
using CleanMovie.Application.Interfaces;
using CleanMovie.Application.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanMovie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : BaseApiController
    {
        private readonly IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }
        [HttpPost]
        public async Task<ActionResult> CreateMember([FromBody]CreateMemberCommand member)
        {
            return Ok(await Mediator.Send(member));
        }
        [HttpGet]
        public MovieListsDto GetMemberById([FromQuery] int memberId)
        {
            var members = _memberService.GetMovieListByMember(memberId);
            return members;
        }

    }
}
