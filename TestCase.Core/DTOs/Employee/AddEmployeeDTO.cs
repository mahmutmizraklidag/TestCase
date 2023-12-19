﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCase.Core.DTOs.Employee
{
    public class AddEmployeeDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Type { get; set; }
        public double Voting { get; set; }
    }
}
