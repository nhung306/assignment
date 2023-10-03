using AutoMapper;
using BusinessService.Dtos;
using DataAccess;
using Microsoft.EntityFrameworkCore;

namespace BusinessService
{
    public abstract class BaseService
    {
        protected readonly AssignmentDbContext _dbContext;
        private readonly IMapper _mapper;
        public BaseService(AssignmentDbContext dbContext, IMapper mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public virtual async Task<BaseResponseDto<TDto>> GetAllAsync<TEntity, TDto>() where TEntity : class
        {
            var entities = await _dbContext.Set<TEntity>().ToListAsync();

            var data= _mapper.Map<List<TDto>>(entities);

            var response = new BaseResponseDto<TDto> { TotalRecords = data.Count, Items = data };
            return response;
        }
    }
}
