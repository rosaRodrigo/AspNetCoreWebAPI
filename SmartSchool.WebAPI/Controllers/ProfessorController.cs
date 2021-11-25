using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/Controller")]
    public class ProfessorController : ControllerBase
    {
        public ProfessorController() { }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Professores: Rodrigo, Nicolas, Ana, Amanda");
        }
    }
}