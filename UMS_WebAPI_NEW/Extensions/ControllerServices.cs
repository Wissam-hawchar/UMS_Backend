using UMS_WebAPI_NEW.Filters;

namespace UMS_WebAPI_NEW.Extensions
{
    public static class ControllerServices
    {
        public static IServiceCollection AddControllerServices(this IServiceCollection services)
        {
            services.AddControllers(options =>
            {
                options.Filters.Add(new GlobalExceptionFilter());
            });
            return services;
        }
    }
}
