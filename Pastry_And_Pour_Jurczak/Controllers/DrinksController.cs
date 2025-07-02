//THE DRINKS CONTROLLER HANDLES GET ENDPOINTS FOR DRINK MENU OPTIONS
using Microsoft.AspNetCore.Mvc;
using Bogus;
using Pastry_And_Pour_Jurczak.Models;

namespace Pastry_And_Pour_Jurczak.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DrinksController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<PastryItem>> GetDrinks()
        {
            var faker = new Faker<PastryItem>()
                .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                .RuleFor(p => p.Category, f => "Drink")
                .RuleFor(p => p.Price, f => f.Random.Decimal(2.00m, 5.00m))
                .RuleFor(p => p.Description, f => f.Commerce.ProductDescription());

            var fakeDrinks = faker.Generate(7);

            return Ok(fakeDrinks);
        }
    }
}
