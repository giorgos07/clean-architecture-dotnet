using CleanArchitectureDotNet.Application.Interfaces;
using CleanArchitectureDotNet.Application.ObjectMapping;
using CleanArchitectureDotNet.Application.Services;
using CleanArchitectureDotNet.Bus;
using CleanArchitectureDotNet.Data.Repositories;
using CleanArchitectureDotNet.Domain.CommandHandlers;
using CleanArchitectureDotNet.Domain.Commands;
using CleanArchitectureDotNet.Domain.Core.Bus;
using CleanArchitectureDotNet.Domain.Interfaces;
using MediatR;
using System.Reflection;

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
            services.AddMediatR(Assembly.GetExecutingAssembly());
            // Application layer services
            services.AddScoped<ICourseService, CourseService>();
            services.AddAutoMapper(config => config.AddProfile<MappingProfile>());
            // Data layer services
            services.AddScoped<ICourseRepository, CourseRepository>();
            return services;
        }
    }
}
