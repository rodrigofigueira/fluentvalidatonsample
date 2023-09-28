using FluentValidation;
using FluentValidationsSample.DTO;

namespace FluentValidationsSample.Validators
{
    public class CreateUserValidator : AbstractValidator<UserPostDTO>
    {
        public CreateUserValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .Length(3, 100) 
                    .WithMessage("Nome deve ter entre 3 e 100 caracteres");
            
            RuleFor(c => c.BirthDate)
                .LessThan(DateTime.Now)
                .WithMessage("Data de nascimento deve ser menor que data atual");

            RuleFor(c => c.ProfileId)
                .GreaterThan(0)
                .When(c => c.IsAdmin == false)
                .WithMessage("Se usuário não for administrador o ProfileId deve ser informado");
        }        
    }
}