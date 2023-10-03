using Assignment.Controllers.Model;
using Assignment.DataAccess;
using Assignment.DataAccess.Entities;
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
    }
}

