using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCase.Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProductSubstitution { get; set; }
        public decimal Price { get; set; }
        public List<ProductUse> ProductUse { get; set; }
    }
}
