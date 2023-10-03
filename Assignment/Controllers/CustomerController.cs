using Assignment.Models;
using BusinessService.Contracts;
using BusinessService.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [ApiController]
    [Route("/api/customer")]
    public class CustomerController : BaseController
    {
        private ICustomerService _customerService { get; set; }

        public CustomerController(ICustomerService customerService) : base()
        {
            _customerService = customerService;
		}
        [HttpGet]
        [Route("getAllData")]
        public async Task<BaseResponseDto<CustomerDto>> GetAllAsync()
        {
            return await _customerService.GetAllAsync();
        }

        //[HttpPost]
        //[Route("create")]
        //public override async Task<CustomerModel> CreateAsync(CustomerModel customer)
        //{
        //    //return await _customerService.CreateAsync(customer);
        //}
    }
}

