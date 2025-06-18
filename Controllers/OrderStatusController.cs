using Microsoft.AspNetCore.Mvc;
using Pastry_And_Pour_Jurczak.Models;

namespace Pastry_And_Pour_Jurczak.Controllers
{
    // THIS CONTROLLER HANDLES ORDER STATUS API REQUESTS
    [ApiController]
    [Route("api/order-status")]
    public class OrderStatusController : ControllerBase
    {
        // THIS METHOD RETURNS A SAMPLE ORDER STATUS
        [HttpGet]
        public ActionResult<Order> GetOrderStatus()
        {
            // CREATE A NEW ORDER OBJECT WITH SAMPLE DATA
            Order sampleOrder = new Order
            {
                Id = 1,
                CustomerName = "ALLIE",
                Status = "PROCESSING"
            };

            // RETURN THE SAMPLE ORDER OBJECT AS JSON
            return Ok(sampleOrder);
        }
    }
}
