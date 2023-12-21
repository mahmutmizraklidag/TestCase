using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCase.Core.Entities;
using TestCase.Core.Repositories;
using TestCase.Core.Services;

namespace TestCase.Service.Services
{
    public class ProductUseService : GenericService<ProductUse>, IProductUseService
    {
        public ProductUseService(IGenericRepository<ProductUse> repository) : base(repository)
        {
        }
    }
}
