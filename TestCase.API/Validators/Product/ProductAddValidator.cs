using FluentValidation;
using TestCase.Core.DTOs.Product;
using TestCase.Core.Entities;

namespace TestCase.API.Validators.Product
{
    public class ProductAddValidator : AbstractValidator<AddProductDTO>
    {
        public ProductAddValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı Boş Bırakılamaz");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat Kısmı Boş Geçilemez");

        }
    }
}
