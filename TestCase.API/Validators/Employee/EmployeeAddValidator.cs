using FluentValidation;
using FluentValidation.AspNetCore;
using TestCase.Core.DTOs.Employee;

namespace TestCase.API.Validators.Employee
{
    public class EmployeeAddValidator:AbstractValidator<AddEmployeeDTO>
    {
        public EmployeeAddValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez.");
            RuleFor(x=>x.Surname).NotEmpty().WithMessage("Soyisim alanı boş geçilemez.");
            RuleFor(x=>x.Type).NotEmpty().WithMessage("Ürün Türü alanı boş geçilemez.");
        }
    }
}
