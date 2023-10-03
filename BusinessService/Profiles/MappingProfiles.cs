using AutoMapper;
using BusinessService.Dtos;
using DataAccess.Entities;

namespace BusinessService.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
        }
    }
}
