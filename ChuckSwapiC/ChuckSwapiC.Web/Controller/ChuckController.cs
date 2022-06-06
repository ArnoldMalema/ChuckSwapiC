using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChuckSwapiC.Web.Controller
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ChuckController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("categories")]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
