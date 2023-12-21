using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCase.Core.Entities;
using TestCase.Core.Repositories;
using TestCase.Core.Services;
using TestCase.Repository.Repositories;

namespace TestCase.Service.Services
{
    public class EmployeeService : GenericService<Employee>, IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository):base(repository) 
        {
            _repository = repository;
        }

    }
}
