using Domain.Services;
using Microsoft.Extensions.DependencyInjection;
namespace Infrastructure;

public static class InfrastructureExtension
{
    public static void AddInfrastructure(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IProductRepository, ProductRepository>();
    }
}