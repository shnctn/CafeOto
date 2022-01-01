using CafeOto.Entities.Models;
using FluentValidation;

namespace CafeOto.Entities.Validations
{
    public class MasalarValidator : AbstractValidator<Masalar>
    {
        public MasalarValidator()
        {
            RuleFor(p => p.MasaAdi).NotEmpty().WithMessage("Masa Adı alanı boş geçilemez");
        }
    }
}
