using Microsoft.AspNetCore.Mvc;
using WebApp.Model;
using WebApp.Service;

namespace WebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProfesorController : ControllerBase
    {
        private readonly IProfesorService _profesorService;

        public ProfesorController(IProfesorService profesorService)
        {
            _profesorService = profesorService; 
        }

        [HttpGet]
        [Route("{id?}")]
        public IActionResult getProfesor(int id)
        {
            Profesor profesor = _profesorService.GetProfesor(id);
            if(profesor != null)
                return Ok(profesor);
            return BadRequest();
        }

        [HttpGet]
        [Route("freeProfesors")]
        public IActionResult GetProfesors()
        {
            List<Profesor> profesors = _profesorService.GetProfesors();
            if (profesors != null)
                return Ok(profesors);
            return BadRequest();
        }

        [HttpGet]
        [Route("schedules/{id?}")]
        public IActionResult GetSchedules(int id)
        {
            List<Schedule> schedules = _profesorService.GetSchedules(id);
            if (schedules != null)
                return Ok(schedules);
            return BadRequest();
        }
    }
}
