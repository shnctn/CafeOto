using CafeOto.Entities.Models;
using FluentValidation;

namespace CafeOto.Entities.Validations
{
    public class UrunValidator : AbstractValidator<Urun>
    {
        public UrunValidator()
        {

            RuleFor(p => p.UrunKodu).NotEmpty().WithMessage("Satış Kodu alanı boş geçilemez");
            RuleFor(p => p.UrunAdi).MinimumLength(3).WithMessage("ürün kodu en az 3 karakterden oluşmalı");
            RuleFor(p => p.BirimFiyat).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(p => p.BirimFiyat2).NotEmpty().WithMessage("Boş geçilemez ");
            RuleFor(p => p.BirimFiyat3).NotEmpty().WithMessage("Boş geçilemez ");

        }
    }
}
