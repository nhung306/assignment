using Assignment.Controllers.Model;
using Assignment.DataAccess;
using Assignment.DataAccess.Entities;
using Assignment.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Controllers
{
    [ApiController]
    [Route("/api/product")]
    public class ProductController : BaseController<Product>
	{
        public ProductController(AssignmentDbContext dbContext) : base(dbContext)
		{
		}
        [HttpPost]
        [Route("create")]
        public override async Task<Product> CreateAsync(Product product)
        {
            return await base.CreateAsync(product);
        }

        [HttpPost]
        [Route("getAllData")]
        public async Task<ModelResponse<Product>> GetAll([FromBody]Request search)
        {
            IQueryable<Product> query = _dbContext.Products;

            if (!string.IsNullOrEmpty(search.SearchText))
            {
                query = query.Where(e => e.Name.Contains(search.SearchText));
            }
            var pagedData = await query
                .Skip((search.PageNumber - 1) * search.PageSize)
                .Take(search.PageSize)
                .ToListAsync();
            var totalRecords = await _dbContext.Products.CountAsync();
            var response = new ModelResponse<Product>
                        {
                            PageNumber = search.PageNumber,
                            PageSize = search.PageSize,
                            TotalPages = (int)totalRecords / search.PageSize,
                            TotalRecords = totalRecords, Items = pagedData
                        };

            return response;
        }
        [HttpGet]
        [Route("addData")]
        public async Task<bool> AddProductToDb()
        {
            try
            {
                int numberOfRecords = 32760;

                for (int i = 0; i < numberOfRecords; i++)
                {

                    var product = new Product()
                    {
                        Name = ProductService.GenerateRandomString(10),
                        ImageUrl = ProductService.GetRandomImageUrl(),
                        Price = ProductService.GenerateRandomDecimal(),
                        ShopId = ProductService.GenerateRandomNumber(1, 3)
                    };


                    _dbContext.Products.Add(product);

                    int rowsAffected = _dbContext.SaveChanges();
                    Console.WriteLine($"Inserted {rowsAffected} rows into the table.");
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }
    }
}

