//THE PASTRIES CONTROLLER WILL RETURN A LIST OF 7 FAKE PASTRY ITEMS USING THE BOGUS LIBRARY
using Microsoft.AspNetCore.Mvc;
using Bogus;
using Pastry_And_Pour_Jurczak.Models;

namespace Pastry_And_Pour_Jurczak.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PastriesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<PastryItem>> GetPastries()
        {
            var faker = new Faker<PastryItem>()
                .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                .RuleFor(p => p.Category, f => f.PickRandom("Pastry", "Drink"))
                .RuleFor(p => p.Price, f => f.Random.Decimal(2.00m, 5.00m))
                .RuleFor(p => p.Description, f => f.Commerce.ProductDescription());

            var fakePastries = faker.Generate(7);

            return Ok(fakePastries);
        }
    }
}
