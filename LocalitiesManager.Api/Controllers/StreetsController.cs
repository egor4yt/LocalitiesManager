using LocalitiesManager.CommandsQueries.Commands.Streets.SeedMany;
using Microsoft.AspNetCore.Mvc;

namespace LocalitiesManager.Api.Controllers;

[Route("streets")]
public class StreetsController : ApiControllerBase
{
    [HttpPost("seed-many")]
    [ProducesResponseType(typeof(SeedManyLocalitiesCommandsResponse), StatusCodes.Status200OK)]
    public async Task<ActionResult<SeedManyLocalitiesCommandsResponse>> SeedMany([FromBody] SeedManyLocalitiesCommandsRequest query)
    {
        var result = await Mediator.Send(query);
        return Ok(result);
    }
}