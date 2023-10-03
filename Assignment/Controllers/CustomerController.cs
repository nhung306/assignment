using Assignment.Controllers.Model;
using Assignment.DataAccess;
using Assignment.DataAccess.Entities;
using Assignment.Services;
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
        [HttpGet]
        [Route("addData")]
        public async Task<bool> AddCustomerToDb()
        {
            try
            {
                int numberOfRecords = 28;

                for (int i = 0; i < numberOfRecords; i++)
                {

                    var customer = new Customer()
                    {
                        FullName = ProductService.GenerateRandomString(10),
                        DateOfBirth = ProductService.GenerateRandomDate(new DateTime(1950, 1, 1), new DateTime(2020, 12, 31)),
                        Email = ProductService.GenerateRandomEmail()
                    };


                    _dbContext.Customers.Add(customer);

                    int rowsAffected = _dbContext.SaveChanges();
                    Console.WriteLine($"Inserted {rowsAffected} rows into the table.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            return true;
        }
    }
}

