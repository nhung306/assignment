using Assignment.Controllers.Model;
using Assignment.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Controllers
{
    [ApiController]
    public class BaseController<TEntity> : ControllerBase where TEntity : class
    {
        protected readonly AssignmentDbContext _dbContext;
        protected DbSet<TEntity> _dbSet { get; set; }
        public BaseController(AssignmentDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        [HttpGet]
        public virtual async Task<BaseResponse<TEntity>> GetAllAsync()
        {
            var pagedData = await _dbSet.ToListAsync();
            var totalRecords = await _dbSet.CountAsync();
            var response = new BaseResponse<TEntity> { TotalRecords = totalRecords, Items = pagedData };
            return response;
        }

        [HttpPost]
        public virtual async Task<TEntity> CreateAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}

