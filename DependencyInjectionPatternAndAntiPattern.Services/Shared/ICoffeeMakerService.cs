using DIPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPattern.Services.Shared
{
    public interface ICoffeeMakerService
    {
        string makeSomeCoffee(Coffee coffee);
    }
}
