using Assignment.Controllers.Model;
using Assignment.DataAccess;
using Assignment.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace Assignment.Controllers
{
    [ApiController]
    [Route("/api/customer")]
    public class CustomerController : BaseController<Customer>
    {
		public CustomerController(AssignmentDbContext dbContext) : base(dbContext)
        {
		}
        [HttpGet]
        [Route("getAllData")]
        public override async Task<BaseResponse<Customer>> GetAllAsync()
        {
            return await base.GetAllAsync();
        }

        [HttpPost]
        [Route("create")]
        public override async Task<Customer> CreateAsync(Customer customer)
        {
            return await base.CreateAsync(customer);
        }
    }
}

