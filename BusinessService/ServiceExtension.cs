using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessService
{
    public static class ServiceExtension
    {
        public static void  AddDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<AssignmentDbContext>(options =>
                        options.UseMySQL(connectionString));
        }
    }
}
