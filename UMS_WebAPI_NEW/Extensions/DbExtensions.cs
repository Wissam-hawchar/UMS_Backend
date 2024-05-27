using Microsoft.EntityFrameworkCore;
using UMS_DAL.Models;

namespace UMS_WebAPI_NEW.Extensions
{
    public static class DbExtensions
    {
        public static IServiceCollection addDb(this IServiceCollection services,ConfigurationManager config)
        {
            var ConnectionString = config.GetConnectionString("DefaultConnection");
            // Add services to the container.
            services.AddDbContext<UmsContext>(options => options.UseSqlServer(ConnectionString));
            return services;
        }
    }
}
