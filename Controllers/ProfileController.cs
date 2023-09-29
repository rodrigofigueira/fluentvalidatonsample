using FluentValidationsSample.DTO;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationsSample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(ProfileDTO profileDTO){
            return Ok();
        }
    }
}