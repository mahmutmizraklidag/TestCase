using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestCase.Core.DTOs.Product;
using TestCase.Core.DTOs.ProductUse;
using TestCase.Core.Entities;
using TestCase.Core.OrderInterface;
using TestCase.Core.Services;
using TestCase.Service.Services;

namespace TestCase.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductUseController : ControllerBase
    {
        private readonly IProductUseService _productUseService;
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IMapper _mapper;
        private readonly IValidator<AddProductUseDTO> _productValidator;
        public ProductUseController(IProductUseService productUseService, IUnitOfWorks unitOfWorks, IMapper mapper, IValidator<AddProductUseDTO> productValidator)
        {
            _productUseService = productUseService;
            _unitOfWorks = unitOfWorks;
            _mapper = mapper;
            _productValidator = productValidator;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_productUseService.GetAll());
        }



        [HttpPost]
        public async Task<IActionResult> AddAsync(AddProductUseDTO addProductUseDTO)
        {
            var productUse = _mapper.Map<ProductUse>(addProductUseDTO);
            await _productUseService.AddAsync(productUse);
            await _unitOfWorks.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAsync(UpdateProductUseDTO updateProductUse)
        {
            var product = _mapper.Map<ProductUse>(updateProductUse);
            _productUseService.Update(product);
            await _unitOfWorks.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            _productUseService.Delete(id);
            await _unitOfWorks.SaveChangesAsync();
            return Ok();
        }


    }
}
