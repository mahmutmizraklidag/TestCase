using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCase.Core.DTOs.Employee;
using TestCase.Core.DTOs.Product;
using TestCase.Core.Entities;

namespace TestCase.Service.AutoMapper
{
    public class EmployeProfile:Profile
    {
        public EmployeProfile()
        {
            CreateMap<Employee, AddEmployeeDTO>().ReverseMap();
            CreateMap<Employee, GetEmployeeDTO>().ReverseMap();
            CreateMap<Employee, UpdateEmployeeDTO>().ReverseMap();
        }
    }
}
