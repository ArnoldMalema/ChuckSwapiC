using ChuckSwapiC.Application.Features.IntegrationQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChuckSwapiC.Web.Controller
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ChuckController : ControllerBase
    {
        private readonly IntegrationQueriesService integrationQueriesService;

        public ChuckController(IntegrationQueriesService integrationQueriesService)
        {
            this.integrationQueriesService = integrationQueriesService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("categories")]
        public IActionResult Get()
        {
            return Ok(integrationQueriesService.GetCnCategories());
        }
    }
}
