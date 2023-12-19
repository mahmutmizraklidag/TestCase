﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCase.Core.DTOs.Product
{
    public class AddProductDTO
    {
        public string Name { get; set; }
        public double Consumption { get; set; }
        public string ProductSubstitution { get; set; }
        public decimal Price { get; set; }
    }
}
