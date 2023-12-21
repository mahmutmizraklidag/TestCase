using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCase.Core.Entities;
using TestCase.Core.Repositories;

namespace TestCase.Repository.Repositories
{
    public class ProductUseRepository : GenericRepository<ProductUse>, IProductUseRepository
    {

        public ProductUseRepository(DbContext dbContext) : base(dbContext)
        {
        }

       
    }
}
