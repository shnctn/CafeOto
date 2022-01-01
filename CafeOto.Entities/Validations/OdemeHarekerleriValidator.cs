using CafeOto.Entities.Models;
using FluentValidation;

namespace CafeOto.Entities.Validations
{
    public class OdemeHarekerleriValidator : AbstractValidator<OdemeHareketleri>
    {
        public OdemeHarekerleriValidator()
        {
            // RuleFor(p => p.SatisKodu).NotEmpty().WithMessage("Menu Adı alanı boş geçilemez");

        }
    }
}
