using Microsoft.AspNetCore.Mvc;

namespace Pastry_And_Pour_Jurczak.Controllers
{
    // THIS CONTROLLER HANDLES THE MENU DISPLAY API
    [ApiController]
    [Route("api/[controller]")]
    public class MenuController : ControllerBase
    {
        // THIS METHOD RETURNS A SIMPLE MENU OBJECT
        [HttpGet]
        public IActionResult GetMenu()
        {
            // CREATE AN OBJECT THAT CONTAINS SAMPLE MENU DATA
            var menu = new
            {
                Pastries = new string[]
                {
                    "CHOCOLATE CROISSANT",
                    "BLUEBERRY MUFFIN",
                    "APPLE STRUDEL"
                },
                Drinks = new string[]
                {
                    "ICED LATTE",
                    "HOT COFFEE",
                    "FRESH LEMONADE"
                }
            };

            
            return Ok(menu);
        }
    }
}
