using Microsoft.AspNetCore.Mvc;
using MyApiSolution.Services;

namespace MyApiSolution.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ICustomerService _customerService;

    public CustomerController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpGet]
    public IActionResult AddCustomer()
    {
        // Call the service method
        return Ok(_customerService.AddCustomer("dan", "dan@dan.com"));
    }
}