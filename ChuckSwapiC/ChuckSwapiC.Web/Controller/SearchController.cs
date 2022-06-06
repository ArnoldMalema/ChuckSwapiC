using ChuckSwapiC.Application.Features.IntegrationQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChuckSwapiC.Web.Controller
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SearchController : ControllerBase
    {
        private readonly IntegrationQueriesService integrationQueriesService;

        public SearchController(IntegrationQueriesService integrationQueriesService)
        {
            this.integrationQueriesService = integrationQueriesService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get(string tag)
        {
            return Ok(integrationQueriesService.Search(tag));
        }
    }
}
