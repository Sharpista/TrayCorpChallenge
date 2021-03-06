using Microsoft.Extensions.DependencyInjection;
using TrayCorpChallenge.DataAcess.Context;
using TrayCorpChallenge.DataAcess.Repositories;
using TrayCorpChallenge.Domain.Interfaces.Repositories;
using TrayCorpChallenge.Domain.Service.Services.Entities;

namespace TrayCorpChallenge.API.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection DependencyResolvers(this IServiceCollection services)
        {
            services.AddScoped<ProductContext>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
            return services;
        }
    }
}
