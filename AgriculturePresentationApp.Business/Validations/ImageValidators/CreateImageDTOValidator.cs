using AgriculturePresentationApp.Entities.DTO_s.ImageDTO_s;
using FluentValidation;

namespace AgriculturePresentationApp.Business.Validations.ImageValidators
{
    public class CreateImageDTOValidator : AbstractValidator<CreateImageDTO>, ICustomValidators
    {
        public CreateImageDTOValidator()
        {
            RuleFor(x => x.Description).NotEmpty().NotNull().WithMessage("Bu alan boş geçilemez!!");
            RuleFor(x => x.Description).MaximumLength(50).MinimumLength(8).WithMessage("En az 8 en fazla 50 karakter girebilirsiniz!!");
            RuleFor(x => x.Title).NotEmpty().NotNull().WithMessage("Bu alan boş geçilemez!!");
            RuleFor(x => x.Title).MaximumLength(20).MinimumLength(3).WithMessage("En az 3 en fazla 20 karakter girebilirsiniz!!");
        }
    }
}
