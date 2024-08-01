using DIPattern.Models;
using DIPattern.Services.Shared;

namespace DIPattern.Services
{
    public class CoffeeMakerService : ICoffeeMakerService
    {
        public string makeSomeCoffee(Coffee coffee)
        {
            return $"Taza de Cafe de {coffee.Name} {coffee.Description} este tiene un nivel de intensidad de {coffee.Intensity}" +
                $" su precio es de: {coffee.Price}";
        }
    }
}
