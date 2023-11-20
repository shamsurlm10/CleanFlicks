using AutoMapper;
using ClassMovie.Domain.DbModels;
using ClassMovie.Domain.Dtos;
using CleanMovie.Application.Services;

namespace CleanMovie.Application
{
    public class MappingProfile: Profile
    {
        public MappingProfile() 
        {
            CreateMap<MovieDto, Movie>();
            CreateMap<CreateMemberCommand, Member>();
            CreateMap<MemberDto, Member>();
            CreateMap<RentalDto, Rental>();
            CreateMap<MovieRentalDto, MovieRental>();
        }
    }
}
