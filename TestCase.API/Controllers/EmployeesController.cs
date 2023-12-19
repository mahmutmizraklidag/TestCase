using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestCase.Core.DTOs.Employee;
using TestCase.Core.DTOs.Product;
using TestCase.Core.Entities;
using TestCase.Core.OrderInterface;
using TestCase.Core.Services;
using TestCase.Service.Services;

namespace TestCase.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;
        private readonly IValidator<AddEmployeeDTO> _employeeValidator;
        private readonly IUnitOfWorks _unitOfWorks;

        public EmployeesController(IEmployeeService employeeService, IMapper mapper, IValidator<AddEmployeeDTO> employeeValidator, IUnitOfWorks unitOfWorks)
        {
            _employeeService = employeeService;
            _mapper = mapper;
            _employeeValidator = employeeValidator;
            _unitOfWorks = unitOfWorks;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _employeeService.GetAllAsync();
            var getDTOs = _mapper.Map<IEnumerable<GetEmployeeDTO>>(result);
            return Ok(getDTOs);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<GetEmployeeDTO>> GetAsync(int id)
        {
            var data = await _employeeService.FindAsync(id);
            if (data is null) return NotFound();

            return Ok(data);
        }
        [HttpPost]
        public async Task<IActionResult> AddAsync(AddEmployeeDTO addProduct)
        {
            var product = _mapper.Map<Employee>(addProduct);
            await _employeeService.AddAsync(product);
            await _unitOfWorks.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAsync(UpdateEmployeeDTO updateProduct)
        {
            var product = _mapper.Map<Employee>(updateProduct);
            _employeeService.Update(product);
            await _unitOfWorks.SaveChangesAsync();

            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            _employeeService.Delete(id);
            await _unitOfWorks.SaveChangesAsync();
            return Ok();
        }
    }
}
