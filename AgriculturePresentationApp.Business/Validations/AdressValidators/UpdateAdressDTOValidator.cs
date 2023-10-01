using AgriculturePresentationApp.Entities.DTO_s.AdressDTO_s;
using FluentValidation;

namespace AgriculturePresentationApp.Business.Validations.AdressValidators
{
    public class UpdateAdressDTOValidator : AbstractValidator<UpdateAdressDTO>, ICustomValidators
    {
        public UpdateAdressDTOValidator()
        {
            RuleFor(x => x.Description1).MaximumLength(50).WithMessage("Adres satırı 50 karakterden az olmalı!!");
            RuleFor(x => x.Description2).MaximumLength(25).WithMessage("Adres satırı 25 karakterden az olmalı!!");
            RuleFor(x => x.Description3).MaximumLength(25).WithMessage("Adres satırı 25 karakterden az olmalı!!");
            RuleFor(x => x.MapInfo).NotEmpty().NotNull().WithMessage("Harita bilgisi boş geçilemez!!");
            RuleFor(x => x.Description1).NotEmpty().NotNull().WithMessage("Adres satırı 1 boş geçilemez!!");
            RuleFor(x => x.Description2).NotEmpty().NotNull().WithMessage("Adres satırı 2 boş geçilemez!!");
            RuleFor(x => x.Description3).NotEmpty().NotNull().WithMessage("Adres satırı 3 boş geçilemez!!");
            RuleFor(x => x.Description4).NotEmpty().NotNull().WithMessage("Telefon numarası boş geçilemez!!");
        }
    }
}
