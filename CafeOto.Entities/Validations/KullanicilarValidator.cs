using CafeOto.Entities.Models;
using FluentValidation;

namespace CafeOto.Entities.Validations
{
    public class KullanicilarValidator : AbstractValidator<Kullanicilar>
    {
        public KullanicilarValidator()
        {
            RuleFor(p => p.AdSoyad).NotEmpty().WithMessage("Ad soyad alanı boş geçilemez");
            RuleFor(p => p.KullaniciAdi).NotEmpty().WithMessage("KUllanıcı adı alanı boş geçilemez").MaximumLength(30).WithMessage("En fazl 20 karakter olmalı").MinimumLength(3).WithMessage("KullanıcıAdı alan 5karakterden az olmamalı");
            RuleFor(p => p.Parola).NotEmpty().WithMessage("Parola alanı boş geçilemez").MaximumLength(30).WithMessage("En fazla 20 karakter olmalı").MinimumLength(2).WithMessage(" Parola alan 2 karakterden az olmamalı");
            RuleFor(p => p.Email).NotEmpty().WithMessage("E-mail alanı boş geçilemez");
            RuleFor(p => p.Telefon).NotEmpty().WithMessage("Telefon alanı boş geçilemez");
            RuleFor(p => p.Email).EmailAddress().WithMessage("Hatalı Email Adresi");

        }
    }
}
