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
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        private readonly IValidator<AddProductDTO> _productValidator;
        private readonly IUnitOfWorks _unitOfWorks;
        public ProductsController(IProductService productService, IMapper mapper, IValidator<AddProductDTO> productValidator, IUnitOfWorks unitOfWorks)
        {
            _productService = productService;
            _mapper = mapper;
            _productValidator = productValidator;
            _unitOfWorks = unitOfWorks;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _productService.GetAllAsync();
            var getDTOs = _mapper.Map<IEnumerable<GetProductDTO>>(result);
            return Ok(getDTOs);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<GetProductDTO>> GetAsync(int id)
        {
            var data = await _productService.FindAsync(id);
            if (data is null) return NotFound();

            return Ok(data);
        }
            [HttpPost]
        public async Task<IActionResult> AddAsync(AddProductDTO addProduct)
        {
            var product =_mapper.Map<Product>(addProduct);
            await _productService.AddAsync(product);
            await _unitOfWorks.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAsync(UpdateProductDTO updateProduct)
        {
            var product=_mapper.Map<Product>(updateProduct);
            _productService.Update(product);
            await _unitOfWorks.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            _productService.Delete(id);
            await _unitOfWorks.SaveChangesAsync();
            return Ok();
        }
    }
}
