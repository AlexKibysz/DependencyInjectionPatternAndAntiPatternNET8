﻿using DIPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPattern.Services.Shared
{
    public interface ICoffeeService
    {

        List<Coffee> generateCoffee(int Count);
    }
}
