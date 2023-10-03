using System;
using Assignment.Controllers.Model;
using Assignment.DataAccess;
using Assignment.DataAccess.Entities;
using Assignment.Services;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [ApiController]
    [Route("/api/shop")]
    public class ShopController : BaseController<Shop>
	{
		public ShopController(AssignmentDbContext dbContext) : base(dbContext)
		{
		}
        [HttpGet]
        [Route("getAllData")]
        public override async Task<BaseResponse<Shop>> GetAllAsync()
        {
            return await base.GetAllAsync();
        }

        [HttpPost]
        [Route("create")]
        public override async Task<Shop> CreateAsync(Shop shop)
        {
            return await base.CreateAsync(shop);
        }
        [HttpGet]
        [Route("addData")]
        public async Task<bool> AddShopToDb()
        {
            try
            {
                int numberOfRecords = 3;

                for (int i = 0; i < numberOfRecords; i++)
                {

                    var shop = new Shop()
                    {
                        Name = ProductService.GenerateRandomString(10),
                        Location = ProductService.GenerateRandomString(10)
                    };


                    _dbContext.Shops.Add(shop);

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

