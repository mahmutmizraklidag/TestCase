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
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DbContext context) : base(context)
        {
        }
    }
}
