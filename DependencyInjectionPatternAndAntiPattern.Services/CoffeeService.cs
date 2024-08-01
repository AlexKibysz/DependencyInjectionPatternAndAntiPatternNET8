using DIPattern.Models;
using DIPattern.Services.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DIPattern.Services
{
    public class CoffeeService : ICoffeeService
    {
        public List<Coffee> generateCoffee(int count)
        {
            return new List<Coffee>
        {
            new Coffee
            {
                Id = 1,
                Name = "Espresso",
                Description = "A strong and bold coffee with a rich flavor.",
                Intensity = 8,
                Price = 2.99m,
                Origin = "Italy",
                DateOfRoast = new DateTime(2024, 7, 15),
                Picture = "https://example.com/espresso.jpg"
            },
            new Coffee
            {
                Id = 2,
                Name = "Latte",
                Description = "A smooth coffee with a creamy texture.",
                Intensity = 5,
                Price = 3.49m,
                Origin = "USA",
                DateOfRoast = new DateTime(2024, 6, 10),
                Picture = "https://example.com/latte.jpg"
            },
            new Coffee
            {
                Id = 3,
                Name = "Cappuccino",
                Description = "A classic coffee with a balance of espresso and steamed milk.",
                Intensity = 6,
                Price = 3.99m,
                Origin = "Italy",
                DateOfRoast = new DateTime(2024, 5, 20),
                Picture = "https://example.com/cappuccino.jpg"
            },
            new Coffee
            {
                Id = 4,
                Name = "Mocha",
                Description = "A chocolate-flavored coffee with a hint of sweetness.",
                Intensity = 7,
                Price = 4.29m,
                Origin = "Colombia",
                DateOfRoast = new DateTime(2024, 4, 30),
                Picture = "https://example.com/mocha.jpg"
            },
            new Coffee
            {
                Id = 5,
                Name = "Americano",
                Description = "A diluted espresso with a robust flavor.",
                Intensity = 4,
                Price = 2.79m,
                Origin = "USA",
                DateOfRoast = new DateTime(2024, 3, 25),
                Picture = "https://example.com/americano.jpg"
            }
        };

        }
    }
}
