using Azure.Core;
using CleanArchitecture.Presenters;
using CleanArchitecture.RepositoryEFCore;
using CleanArchitecture.UseCases;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddCleanArchitectureDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepositories(configuration);
            services.AddUseCases();
            services.AddPresenters();
            return services;
        }
    }
}
