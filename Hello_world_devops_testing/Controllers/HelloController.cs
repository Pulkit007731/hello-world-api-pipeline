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
            return Ok("Hello World – CI/CD test successful! v1.1 - Deployment automated");
        }
    }
}
