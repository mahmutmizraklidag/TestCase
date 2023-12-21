using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCase.Core.DTOs.ProductUse
{
    public class GetProductUseDTO
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ProductId { get; set; }
        public double Consumption { get; set; }
    }
}
