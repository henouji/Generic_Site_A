using Microsoft.AspNetCore.Mvc;

namespace SiteAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("This is a sample API endpoint.");
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            // Process the input value
            // ...

            return Ok($"Received value: {value}");
        }
    }
}