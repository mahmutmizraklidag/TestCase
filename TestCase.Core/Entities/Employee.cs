using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCase.Core.Repositories;

namespace TestCase.Core.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Type { get; set; }
        public double Voting { get; set; }
        public List<Product> Products { get; set; }
    }
}
