using AgriculturePresentationApp.Entities.DTO_s.TeamDTO_s;
using FluentValidation;

namespace AgriculturePresentationApp.Business.Validations.TeamValidators
{
    public class CreateTeamDTOValidator : AbstractValidator<CreateTeamDTO>, ICustomValidators
    {
        public CreateTeamDTOValidator()
        {
            RuleFor(x => x.FullName).NotEmpty().NotNull().WithMessage("Bu alan boş geçilemez!!");
            RuleFor(x => x.FullName).MaximumLength(50).MinimumLength(3).WithMessage("En az 3 en fazla 50 karakter girebilirsiniz!!");
            RuleFor(x => x.Title).NotEmpty().NotNull().WithMessage("Bu alan boş geçilemez!!");
            RuleFor(x => x.Title).MaximumLength(100).MinimumLength(3).WithMessage("En az 3 en fazla 100 karakter girebilirsiniz!!");     
        }
    }
}
