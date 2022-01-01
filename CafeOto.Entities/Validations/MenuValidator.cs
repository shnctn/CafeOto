using CafeOto.Entities.Models;
using FluentValidation;

namespace CafeOto.Entities.Validations
{
    public class MenuValidator : AbstractValidator<Menu>
    {
        public MenuValidator()
        {
            RuleFor(p => p.Adi).NotEmpty().WithMessage("Menu Adı alanı boş geçilemez");
            RuleFor(p => p.Adi).MinimumLength(3).WithMessage("Menu Adı alanı en az 3 karakterden oluşmalıdır.");
            RuleFor(p => p.Adi).MaximumLength(13).WithMessage("Menu Adı alanı en fazla 13 karakterden oluşmalıdır.");

        }
    }
}
