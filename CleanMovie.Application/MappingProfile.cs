using AutoMapper;
using ClassMovie.Domain.DbModels;
using ClassMovie.Domain.Dtos;

namespace CleanMovie.Application
{
    public class MappingProfile: Profile
    {
        public MappingProfile() 
        {
            CreateMap<MovieDto, Movie>();
            CreateMap<MemberDto, Member>();
            CreateMap<RentalDto, Rental>();
            CreateMap<MovieRentalDto, MovieRental>();
        }
    }
}
