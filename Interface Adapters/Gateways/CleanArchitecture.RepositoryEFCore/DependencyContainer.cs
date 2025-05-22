using CleanArchitecture.Entities.Interfaces;
using CleanArchitecture.RepositoryEFCore.DataContext;
using CleanArchitecture.RepositoryEFCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.RepositoryEFCore
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CleanArchitectureContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("CleanArchitectureDB")));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
