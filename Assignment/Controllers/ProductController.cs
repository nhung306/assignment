using Assignment.Models;
using BusinessService.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [ApiController]
    [Route("/api/product")]
    public class ProductController : BaseController
	{
        private IProductService _productService { get; set; }

        public ProductController(IProductService productService) : base()
		{
		}
        //[HttpPost]
        //[Route("create")]
        //public override async Task<Product> CreateAsync(Product product)
        //{
        //    return await base.CreateAsync(product);
        //}

        //[HttpPost]
        //[Route("getAllData")]
        //public async Task<ModelResponse<ProductModel>> GetAll([FromBody]Request search)
        //{
        //    //IQueryable<Product> query = _dbContext.Products;

        //    //if (!string.IsNullOrEmpty(search.SearchText))
        //    //{
        //    //    query = query.Where(e => e.Name.Contains(search.SearchText));
        //    //}
        //    //var pagedData = await query
        //    //    .Skip((search.PageNumber - 1) * search.PageSize)
        //    //    .Take(search.PageSize)
        //    //    .ToListAsync();
        //    //var totalRecords = await _dbContext.Products.CountAsync();
        //    //var response = new ModelResponse<Product>
        //    //            {
        //    //                PageNumber = search.PageNumber,
        //    //                PageSize = search.PageSize,
        //    //                TotalPages = (int)totalRecords / search.PageSize,
        //    //                TotalRecords = totalRecords, Items = pagedData
        //    //            };

        //    //return response;
        //}
    }
}

