using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCase.Core.OrderInterface;

namespace TestCase.Service
{
    public class UnitOfWorks : IUnitOfWorks
    {
        private readonly DbContext _dbContext;

        public UnitOfWorks(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
