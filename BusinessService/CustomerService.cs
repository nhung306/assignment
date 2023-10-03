using AutoMapper;
using BusinessService.Contracts;
using BusinessService.Dtos;
using DataAccess;
using DataAccess.Entities;

namespace BusinessService
{
    public class CustomerService : BaseService, ICustomerService
    {
        public CustomerService(AssignmentDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public Task<BaseResponseDto<CustomerDto>> GetAllAsync()
        {
            return base.GetAllAsync<Customer, CustomerDto>();
        }
    }
}