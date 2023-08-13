using LocalitiesManager.Api.CommandsQueries.Commands.Localities.CreateOne;
using LocalitiesManager.Api.CommandsQueries.Commands.Localities.DeleteOne;
using LocalitiesManager.Api.CommandsQueries.Commands.Localities.UpdateOne;
using LocalitiesManager.Api.CommandsQueries.Queries.Localities.Filter;
using LocalitiesManager.Api.CommandsQueries.Queries.Localities.GetById;
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

    [HttpGet("{localityId:long}")]
    [ProducesResponseType(typeof(GetByIdLocalitiesCommandsResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<GetByIdLocalitiesCommandsResponse>> Filter([FromRoute] long localityId)
    {
        var query = new GetByIdLocalitiesCommandsQuery();
        query.LocalityId = localityId;
        var result = await Mediator.Send(query);
        return Ok(result);
    }

    [HttpPost("create-one")]
    [ProducesResponseType(typeof(CreateOneLocalitiesCommandsResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<CreateOneLocalitiesCommandsResponse>> CreateOne([FromBody] CreateOneLocalitiesCommandsRequest query)
    {
        var result = await Mediator.Send(query);
        return Ok(result);
    }

    [HttpPut("update/{localityId:long}")]
    [ProducesResponseType(typeof(UpdateOneLocalitiesCommandsResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<UpdateOneLocalitiesCommandsResponse>> UpdateOne([FromBody] UpdateOneLocalitiesCommandsRequest request, [FromRoute] long localityId)
    {
        request.LocalityId = localityId;
        var result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpDelete("delete/{localityId:long}")]
    [ProducesResponseType(typeof(UpdateOneLocalitiesCommandsResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<UpdateOneLocalitiesCommandsResponse>> UpdateOne([FromRoute] long localityId)
    {
        var request = new DeleteOneLocalitiesCommandsRequest();
        request.LocalityId = localityId;
        await Mediator.Send(request);
        return Ok();
    }
}