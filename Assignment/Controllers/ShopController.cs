using Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [ApiController]
    [Route("/api/shop")]
    public class ShopController : BaseController
	{
		public ShopController() : base()
		{
		}
        //[HttpGet]
        //[Route("")]
        //public override async Task<BaseResponse<Shop>> GetAllAsync()
        //{
        //    return await base.GetAllAsync();
        //}

        //[HttpPost]
        //[Route("")]
        //public override async Task<Shop> CreateAsync(Shop shop)
        //{
        //    return await base.CreateAsync(shop);
        //}
    }
}

