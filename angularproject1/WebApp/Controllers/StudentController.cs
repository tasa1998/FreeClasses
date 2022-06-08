using Microsoft.AspNetCore.Mvc;
using WebApp.Dto;
using WebApp.Model;
using WebApp.Service;

namespace WebApp.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;   
        }
        //[HttpPost]
        //[Route("add")]
        //public IActionResult AddStudent([FromBody] Student studentt)
        //{
        //    Student student = _studentService.AddStudent(studentt);
        //    if (student != null)
        //        return Ok(student);
        //    return BadRequest();
        //}

        [HttpPost]
        [Route("add")]
        public IActionResult AddStudent([FromBody] ScheduleClassDto studentt)
        {
            Student student = _studentService.AddStudentFromDto(studentt);
            if (student != null)
                return Ok(student);
            return BadRequest();
        }


    }
}
