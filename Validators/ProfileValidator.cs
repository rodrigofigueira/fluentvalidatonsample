using FluentValidation;
using FluentValidationsSample.DTO;

namespace FluentValidationsSample.Validators
{
    public class ProfileValidator: AbstractValidator<ProfileDTO>
    {
        public ProfileValidator()
        {
            RuleFor(c => c.Id)
                .GreaterThan(0)
                .WithMessage("Id deve ser maior que zero");

            RuleFor(c => c.Description)
                .NotEmpty()
                .WithMessage("Campo obrigatório");    
        }
    }
}