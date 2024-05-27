using UMS_BLL.Mapping;

namespace UMS_WebAPI_NEW.Extensions
{
    public static class autoMapperExtension
    {
        public static IServiceCollection AddAutoMappperConfig(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            }, typeof(Program));
            return services;
        }
    }
}
