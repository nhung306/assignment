using System;
using Assignment.Controllers.Model;
using Assignment.DataAccess;
using Assignment.DataAccess.Entities;
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
        [Route("")]
        public override async Task<BaseResponse<Shop>> GetAllAsync()
        {
            return await base.GetAllAsync();
        }

        [HttpPost]
        [Route("")]
        public override async Task<Shop> CreateAsync(Shop shop)
        {
            return await base.CreateAsync(shop);
        }
    }
}

