using System.Net;
using LocalitiesManager.CommandsQueries.Commands.Localities.CreateOne;
using LocalitiesManager.CommandsQueries.Queries.Localities.Filter;
using Microsoft.AspNetCore.Mvc;

namespace LocalitiesManager.Api.Controllers;

[Route("localities")]
public class LocalitiesController : ApiControllerBase
{
    [HttpGet("filter")]
    [ProducesResponseType(typeof(FilterLocalitiesQueriesResponse), StatusCodes.Status200OK)]
    public async Task<ActionResult<FilterLocalitiesQueriesResponse>> Filter([FromQuery] FilterLocalitiesQueriesQuery query)
    {
        var result = await Mediator.Send(query);
        return Ok(result);
    }
    
    [HttpPost("create-one")]
    [ProducesResponseType(typeof(CreateOneLocalitiesCommandsResponse), StatusCodes.Status200OK)]
    public async Task<ActionResult<CreateOneLocalitiesCommandsResponse>> CreateOne([FromBody] CreateOneLocalitiesCommandsRequest query)
    {
        var result = await Mediator.Send(query);
        return Ok(result);
    }
}