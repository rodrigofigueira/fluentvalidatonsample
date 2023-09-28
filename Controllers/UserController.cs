using FluentValidation;
using FluentValidationsSample.DTO;
using FluentValidationsSample.Validators;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationsSample.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : Controller
    {

        // Primeira forma de usar o validador
        // Sendo somente necessário a inclusão da linha
        // builder.Services.AddValidatorsFromAssemblyContaining<CreateUserValidator>(); em Program
        // [HttpPost]
        // public IActionResult Post(UserPostDTO userPostDTO){
        //     var validator = new CreateUserValidator();
        //     var result = validator.Validate(userPostDTO);

        //     if(!result.IsValid){
        //         var errors = result.Errors.Select(e => e.ErrorMessage);
        //         return BadRequest(errors);
        //     }

        //     return Ok();
        // }

        // Segunda forma de usar o validador
        // Sendo somente necessário a inclusão da linha
        // builder.Services.AddValidatorsFromAssemblyContaining<CreateUserValidator>(); em Program
        // e não há a necessidade de instanciar o validador
        // [HttpPost]
        // public IActionResult Post(UserPostDTO userPostDTO, [FromServices] IValidator<UserPostDTO> validator){
        //     var result = validator.Validate(userPostDTO);

        //     if(!result.IsValid){
        //         var errors = result.Errors.Select(e => e.ErrorMessage);
        //         return BadRequest(errors);
        //     }

        //     return Ok();
        // }

        // Terceira forma do validador fica totalmente desacoplada
        // bastando adicionar a linha builder.Services.AddFluentValidationAutoValidation();
        // o custo é que o response body do erro é diferente dos outros dois exemplos
        [HttpPost]
        public IActionResult Post(UserPostDTO userPostDTO){
            return Ok();
        }

    }
}