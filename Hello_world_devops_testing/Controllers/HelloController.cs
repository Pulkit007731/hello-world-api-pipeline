using Microsoft.AspNetCore.Mvc;

namespace Hello_world_devops_testing.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from the feature branch! ");
        }
    }
}
