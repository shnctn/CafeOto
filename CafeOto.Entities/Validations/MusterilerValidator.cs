using CafeOto.Entities.Models;
using FluentValidation;

namespace CafeOto.Entities.Validations
{
    public class MusterilerValidator : AbstractValidator<Musteriler>
    {
        public MusterilerValidator()
        {
            RuleFor(p => p.AdSoyad).NotEmpty().WithMessage("Ad soyad alanı boş geçilemez");
            RuleFor(p => p.telefon).NotEmpty().WithMessage("Telefon alanı boş geçilemez");

        }
    }
}
