using Domain.Entities;

namespace Domain.Services;

public interface IProductRepository
{
    public bool IsExistProduct(string code);
    Guid Add(ProductEntity productEntity);
}