using ChuckSwapiC.Application.Features.IntegrationQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChuckSwapiC.Web.Controller
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class JokesController : ControllerBase
    {
        private readonly IntegrationQueriesService integrationQueriesService;

        public JokesController(IntegrationQueriesService integrationQueriesService)
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

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("category")]
        public IActionResult Get(string category)
        {
            return Ok(integrationQueriesService.GetJokeFromRandomCategory(category));
        }
    }
}
