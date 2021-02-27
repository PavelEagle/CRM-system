using FileDataService.Abstraction;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserService.Abstraction;
using WbaApp.Repositories.Abstraction.FileData;
using WbaApp.Repositories.Abstraction.User;
using WbaApp.Repositories.DAL.FileData;
using WbaApp.Repositories.DAL.User;

namespace WebApp.Server.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IFileDataService, FileDataService.FileDataService>();
            services.AddScoped<IUserService, UserService.UserService>();
            
            return services;
        }

        public static IServiceCollection ConfigureCustomRepositories(this IServiceCollection services)
        {
            services.AddScoped<IFileRepository, FileRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            
            return services;
        }
    }
}