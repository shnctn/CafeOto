using CafeOto.Entities.Models;
using FluentValidation;

namespace CafeOto.Entities.Validations
{
    public class MasaHareketleriValidator : AbstractValidator<MasaHareketleri>
    {
        public MasaHareketleriValidator()
        {
            RuleFor(p => p.SatisKodu).NotEmpty().WithMessage("Satış Kodu alanı boş geçilemez");
           // RuleFor(p => p.SatisKodu).Length(12).WithMessage("Satış kodu 12 karakterden oluşmalı");
            RuleFor(p => p.Miktari).NotEmpty().WithMessage("Parola alanı boş geçilemez");
            RuleFor(p => p.Miktari).GreaterThan(0).WithMessage("sıfır olamaz");
            RuleFor(p => p.BirimFiyati).NotEmpty().WithMessage("PBirim fiyatı alanı boş geçilemez");
           // RuleFor(p => p.BirimFiyati).LessThanOrEqualTo(150).WithMessage("En fazla 150 olabilir ");

        }
    }
}
