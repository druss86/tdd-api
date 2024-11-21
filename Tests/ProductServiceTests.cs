using MyApiSolution.Services;

namespace Tests;

public class ProductServiceTests
{
    private readonly ProductService _service;

    public ProductServiceTests()
    {
        _service = new ProductService();
    }

    [Fact]
    public void AddProduct_ShouldReturnValidProductId()
    {
        var result = _service.AddProduct("Laptop", 999.99m);
        Assert.True(result > 0);
    }

    [Fact]
    public void AddProduct_ShouldFailForNegativePrice()
    {
        var result = _service.AddProduct("Laptop", -10.00m);
        Assert.Equal(0, result);
    }

    [Fact]
    public void RemoveProduct_ShouldReturnTrueIfSuccessful()
    {
        var result = _service.RemoveProduct(1);
        Assert.True(result);
    }

    [Fact]
    public void RemoveProduct_ShouldReturnFalseForNonexistentProduct()
    {
        var result = _service.RemoveProduct(999);
        Assert.False(result);
    }

    [Fact]
    public void GetAllProducts_ShouldReturnListOfProducts()
    {
        var result = _service.GetAllProducts();
        Assert.NotEmpty(result);
    }
}