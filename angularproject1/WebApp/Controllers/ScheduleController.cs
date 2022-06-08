using Microsoft.AspNetCore.Mvc;
using WebApp.Service;

namespace WebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {

        private readonly IScheduleService _scheduleService;

        public ScheduleController(IScheduleService scheduleSevice)
        {
            _scheduleService = scheduleSevice;
        }
        [HttpDelete]
        [Route("delete/{id?}")]
        public IActionResult DeleteTenderOffer(int id)
        {
            if (_scheduleService.Delete(id))
                return Ok(true);
            return BadRequest();
        }
    }
}
