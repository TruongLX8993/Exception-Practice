using Domain.Entities;
using Domain.Services;

namespace Infrastructure;

public class ProductRepository : IProductRepository
{
    public bool IsExistProduct(string code)
    {
        throw new InfrastructureException("Connection database is error");
    }

    public Guid Add(ProductEntity productEntity)
    {
        return Guid.NewGuid();
    }
}