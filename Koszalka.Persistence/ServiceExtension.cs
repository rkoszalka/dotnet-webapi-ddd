using Koszalka.Application.Repositories;
using Koszalka.Persistence.Repositories;
using Koszalka.WebAPI.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Koszalka.Persistence
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IToDoRepository, ToDoRepository>();

        }
    }
}