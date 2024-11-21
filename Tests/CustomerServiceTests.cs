using MyApiSolution.Services;

namespace Tests;

public class CustomerServiceTests
{
    private readonly CustomerService _service = new();

    [Fact]
    public void AddCustomer_ShouldReturnValidCustomerId()
    {
        var result = _service.AddCustomer("John Doe", "john@example.com");
        Assert.True(result > 0);
    }

    [Fact]
    public void AddCustomer_ShouldFailForInvalidEmail()
    {
        var result = _service.AddCustomer("John Doe", "invalid-email");
        Assert.Equal(0, result);
    }

    [Fact]
    public void RemoveCustomer_ShouldReturnTrueIfSuccessful()
    {
        var result = _service.RemoveCustomer(1);
        Assert.True(result);
    }

    [Fact]
    public void RemoveCustomer_ShouldReturnFalseForNonexistentCustomer()
    {
        var result = _service.RemoveCustomer(999);
        Assert.False(result);
    }

    [Fact]
    public void GetCustomerDetails_ShouldReturnDetailsForValidId()
    {
        var result = _service.GetCustomerDetails(1);
        Assert.NotNull(result);
    }
}