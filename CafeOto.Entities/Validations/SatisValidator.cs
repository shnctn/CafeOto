using CafeOto.Entities.Models;
using FluentValidation;

namespace CafeOto.Entities.Validations
{
    public class SatisValidator : AbstractValidator<Satislar>
    {
        public SatisValidator()
        {
            RuleFor(p => p.SatisKodu).NotEmpty().WithMessage("atış Kodu alanı boş geçilemez");

        }
    }
}
