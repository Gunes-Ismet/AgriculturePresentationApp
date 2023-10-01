using AgriculturePresentationApp.Entities.DTO_s.AssistanceDTO_s;
using FluentValidation;

namespace AgriculturePresentationApp.Business.Validations.AssistanceValidators
{
    public class UpdateAssistanceDTOValidator : AbstractValidator<UpdateAssistanceDTO>, ICustomValidators
    {
        public UpdateAssistanceDTOValidator()
        {
            RuleFor(x => x.Title).NotEmpty().NotNull().WithMessage("Bu alan boş geçilemez!!");
            RuleFor(x => x.Title).MaximumLength(50).MinimumLength(3).WithMessage("En az 3 en fazla 50 karakter girebilirsiniz!!");
            RuleFor(x => x.Description).MaximumLength(600).MinimumLength(3).WithMessage("En az 3 en fazla 600 karakter girebilirsiniz!!");
            RuleFor(x => x.Description).NotEmpty().NotNull().WithMessage("Bu alan boş geçilemez!!");
        }
    }
}
