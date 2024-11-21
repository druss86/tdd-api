using MyApiSolution.Services;

namespace Tests;

public class OrderServiceTests
{
    private readonly OrderService _service;

    public OrderServiceTests()
    {
        _service = new OrderService();
    }

    [Fact]
    public void PlaceOrder_ShouldReturnValidOrderId()
    {
        var result = _service.PlaceOrder(1, new List<int> { 101, 102 });
        Assert.True(result > 0);
    }

    [Fact]
    public void PlaceOrder_ShouldFailForEmptyProductList()
    {
        var result = _service.PlaceOrder(1, new List<int>());
        Assert.Equal(0, result);
    }

    [Fact]
    public void CancelOrder_ShouldReturnTrueIfSuccessful()
    {
        var result = _service.CancelOrder(1);
        Assert.True(result);
    }

    [Fact]
    public void CancelOrder_ShouldReturnFalseForNonexistentOrder()
    {
        var result = _service.CancelOrder(999);
        Assert.False(result);
    }

    [Fact]
    public void GetOrderDetails_ShouldReturnProductIds()
    {
        var result = _service.GetOrderDetails(1);
        Assert.NotEmpty(result);
    }
}