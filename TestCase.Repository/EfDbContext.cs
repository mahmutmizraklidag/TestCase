using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCase.Core.Entities;

namespace TestCase.Repository
{
    public class EfDbContext :DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public EfDbContext(DbContextOptions<EfDbContext> options):base(options) 
        {
                
        }
    }
}
