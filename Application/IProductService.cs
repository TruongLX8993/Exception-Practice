namespace Application;

public interface IProductService
{
    SearchProductResponse Search(SearchProductRequest request);
    CreateProductResponse Create(CreateProductRequest request);
}