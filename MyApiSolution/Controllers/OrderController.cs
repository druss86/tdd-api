using Microsoft.AspNetCore.Mvc;
using MyApiSolution.Services;

namespace MyApiSolution.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpPost]
    public IActionResult CreateOrder()
    {
        // Example call to service method
        _orderService.PlaceOrder(1, new List<int> { 1, 2 });
        return Ok();
    }
}