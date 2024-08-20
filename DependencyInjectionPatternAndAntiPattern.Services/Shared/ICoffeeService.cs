using DIPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPattern.Services.Shared
{
    public interface ICoffeeService
    {

        Task<IEnumerable<Coffee>> GenerateCoffeesAsync();


        Task<Coffee> GetCoffeeByIdAsync(int id);
    }
}
