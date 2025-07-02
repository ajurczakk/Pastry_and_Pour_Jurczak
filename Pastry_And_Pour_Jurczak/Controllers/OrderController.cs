using Microsoft.AspNetCore.Mvc;
using Pastry_And_Pour_Jurczak.Models;

namespace Pastry_And_Pour_Jurczak.Controllers
{
    // THIS CONTROLLER HANDLES CUSTOMER ORDERS
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        // THIS METHOD SUBMITS A NEW ORDER AND RETURNS A CONFIRMATION
        [HttpPost("submit")]
        public IActionResult SubmitOrder([FromBody] Order order)
        {
            // VALIDATE THE ORDER DATA
            if (order == null || string.IsNullOrWhiteSpace(order.CustomerName))
            {
                return BadRequest("ORDER INFORMATION IS INVALID");
            }

            // RETURN A CONFIRMATION MESSAGE
            return Ok("ORDER RECEIVED FOR - " + order.CustomerName);
        }
    }
}
