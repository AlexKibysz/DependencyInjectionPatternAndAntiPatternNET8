using DIPattern.Models;
using DIPattern.Services;
using DIPattern.Services.Shared;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DIPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeMakerController : ControllerBase
    {
      
        private readonly ILogger<CoffeeMakerController> _logger;

        private readonly ICoffeeService _coffeeService;


        private readonly ICoffeeMakerService _coffeeMakerService;


        public CoffeeMakerController(ILogger<CoffeeMakerController> logger, ICoffeeMakerService coffeeMakerService, ICoffeeService coffeeServ)
        {
            _logger = logger;
            _coffeeMakerService = coffeeMakerService;
            _coffeeService  = coffeeServ;
        }


        [HttpGet("all", Name = "GetMeCoffee")]
        public async Task<ActionResult<IEnumerable<Coffee>>> Get()

        {
            return Ok(_coffeeService.generateCoffee(20));
        }

        [HttpGet("{id}", Name = "GetMakeCoffee")]
        public IActionResult MakeCoffeeByID(int id)
        {
            List<Coffee> coffeeTypes = _coffeeService.generateCoffee(50);
           
            return Ok(_coffeeMakerService.makeSomeCoffee(coffeeTypes.SingleOrDefault(x => x.Id == id)));
        }

    }
}
