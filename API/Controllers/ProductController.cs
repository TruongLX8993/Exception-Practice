using Application;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("/api/product")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }
    [HttpGet("")]
    public IActionResult Search(string? keyword)
    {
        _productService.Search(new SearchProductRequest { Keyword = keyword });
        return Ok();
    }
}