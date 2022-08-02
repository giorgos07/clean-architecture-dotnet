using CleanArchitectureDotNet.Application.Interfaces;
using CleanArchitectureDotNet.Application.Services;
using CleanArchitectureDotNet.Data.Repositories;
using CleanArchitectureDotNet.Domain.Interfaces;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyContainer
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            // Application layer services.
            services.AddScoped<ICourseService, CourseService>();
            // Data layer services.
            services.AddScoped<ICourseRepository, CourseRepository>();
            return services;
        }
    }
}
