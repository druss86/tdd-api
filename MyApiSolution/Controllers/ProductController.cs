using Microsoft.AspNetCore.Mvc;
using MyApiSolution.Services;

namespace MyApiSolution.Controllers;


[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public IActionResult GetAllProducts()
    {
        // Example call to service method
        return Ok(_productService.GetAllProducts());
    }
}