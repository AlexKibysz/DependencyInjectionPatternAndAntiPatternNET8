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
            try
            {
                var coffees = await _coffeeService.GenerateCoffeesAsync();
                return Ok(coffees);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener la lista de coffees");
                return StatusCode(500, "Error interno del servidor");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<string>> MakeCoffeeByIdAsync(int id)
        {
            try
            {
                var coffee = await _coffeeService.GetCoffeeByIdAsync(id);
                if (coffee == null)
                {
                    return NotFound("Coffee no encontrado");
                }

                var result = await _coffeeMakerService.MakeSomeCoffeeAsync(coffee);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al preparar el coffee");
                return StatusCode(500, "Error interno del servidor");
            }
        }

    }
}
