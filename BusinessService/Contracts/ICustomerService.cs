using BusinessService.Dtos;

namespace BusinessService.Contracts
{
    public interface ICustomerService
    {
        Task<BaseResponseDto<CustomerDto>> GetAllAsync();
    }
}
