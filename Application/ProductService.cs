using Domain.Entities;
using Domain.Services;

namespace Application;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public SearchProductResponse Search(SearchProductRequest request)
    {
        throw new Exception("Database connection has error");
    }

    public CreateProductResponse Create(CreateProductRequest request)
    {
        var isExist = _productRepository.IsExistProduct(request.Code);
        if (isExist)
            throw new AppException($"Exist product code: {request.Code}");
        var id = _productRepository.Add(new ProductEntity());
        return new CreateProductResponse { Id = id };
    }
}