using UMS_BLL.Services.Auth;
using UMS_BLL.Services.Faculties;
using UMS_BLL.Services.Majors;
using UMS_BLL.Services.Users;
using UMS_DAL.Repositries.Faculties;
using UMS_DAL.Repositries.Majors;
using UMS_DAL.Repositries.Users;

namespace UMS_WebAPI_NEW.Extensions
{
    public static class RepositoryExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IFacultyRepository, FacultyRepository>();
            services.AddScoped<IMajorRepository, MajorRepository>();
            services.AddScoped<IUserRepository, UserRepository>();  
            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IFacultyService, FacultyService>();
            services.AddScoped<IMajorService, MajorService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService, AuthService>();
            return services;
        }
    }
}
