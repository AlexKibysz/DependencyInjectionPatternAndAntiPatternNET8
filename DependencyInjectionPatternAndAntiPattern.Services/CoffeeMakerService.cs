using DIPattern.Models;
using DIPattern.Services.Shared;

namespace DIPattern.Services
{
    public class CoffeeMakerService : ICoffeeMakerService
    {
        public async Task<string> MakeSomeCoffeeAsync(Coffee coffee)
        {
            // Simulación de la preparación del coffee
            await Task.Delay(50000);
            return $"Coffee {coffee.Name} preparado";
        }


    }
}
