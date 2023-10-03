using Assignment.Models;
using AutoMapper;
using BusinessService.Dtos;

namespace Assignment.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<CustomerModel, CustomerDto>().ReverseMap();
        }
    }
}
