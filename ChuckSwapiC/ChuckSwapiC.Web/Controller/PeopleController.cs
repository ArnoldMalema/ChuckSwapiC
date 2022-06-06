using ChuckSwapiC.Application.Features.IntegrationQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChuckSwapiC.Web.Controller
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly IntegrationQueriesService integrationQueriesService;

        public PeopleController(IntegrationQueriesService integrationQueriesService)
        {
            this.integrationQueriesService = integrationQueriesService;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("people")]
        public IActionResult Get()
        {
            return Ok(integrationQueriesService.GetAllSwPeople());
        }
    }
}
