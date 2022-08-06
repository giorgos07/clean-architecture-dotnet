using CleanArchitectureDotNet.Application.Interfaces;
using CleanArchitectureDotNet.Application.Services;
using CleanArchitectureDotNet.Bus;
using CleanArchitectureDotNet.Data.Repositories;
using CleanArchitectureDotNet.Domain.CommandHandlers;
using CleanArchitectureDotNet.Domain.Commands;
using CleanArchitectureDotNet.Domain.Core.Bus;
using CleanArchitectureDotNet.Domain.Interfaces;
using MediatR;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyContainer
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            // Core domain services
            services.AddScoped<IMediatorHandler, InMemoryBus>();
            // Domain services
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CreateCourseCommandHandler>();
            // Application layer services
            services.AddScoped<ICourseService, CourseService>();
            // Data layer services
            services.AddScoped<ICourseRepository, CourseRepository>();
            return services;
        }
    }
}
