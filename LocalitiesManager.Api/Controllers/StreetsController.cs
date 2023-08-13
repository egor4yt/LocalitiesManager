using LocalitiesManager.Api.CommandsQueries.Commands.Streets.CreateOne;
using LocalitiesManager.Api.CommandsQueries.Commands.Streets.DeleteOne;
using LocalitiesManager.Api.CommandsQueries.Commands.Streets.SeedMany;
using LocalitiesManager.Api.CommandsQueries.Commands.Streets.UpdateOne;
using LocalitiesManager.Api.CommandsQueries.Queries.Streets.GetById;
using Microsoft.AspNetCore.Mvc;

namespace LocalitiesManager.Api.Controllers;

[Route("streets")]
public class StreetsController : ApiControllerBase
{
    [HttpPost("seed-many")]
    [ProducesResponseType(typeof(SeedManyStreetsCommandsResponse), StatusCodes.Status200OK)]
    public async Task<ActionResult<SeedManyStreetsCommandsResponse>> SeedMany([FromBody] SeedManyStreetsCommandsRequest query)
    {
        var result = await Mediator.Send(query);
        return Ok(result);
    }

    [HttpGet("{streetId:long}")]
    [ProducesResponseType(typeof(GetByIdStreetsCommandsResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<GetByIdStreetsCommandsResponse>> Filter([FromRoute] long streetId)
    {
        var query = new GetByIdStreetsCommandsQuery();
        query.StreetId = streetId;
        var result = await Mediator.Send(query);
        return Ok(result);
    }

    [HttpPost("create-one")]
    [ProducesResponseType(typeof(CreateOneStreetsCommandsResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<CreateOneStreetsCommandsResponse>> CreateOne([FromBody] CreateOneStreetsCommandsRequest query)
    {
        var result = await Mediator.Send(query);
        return Ok(result);
    }

    [HttpPut("update/{streetId:long}")]
    [ProducesResponseType(typeof(UpdateOneStreetsCommandsResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<UpdateOneStreetsCommandsResponse>> UpdateOne([FromBody] UpdateOneStreetsCommandsRequest request, [FromRoute] long streetId)
    {
        request.StreetId = streetId;
        var result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpDelete("delete/{streetId:long}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> DeleteOne([FromRoute] long streetId)
    {
        var request = new DeleteOneStreetsCommandsRequest();
        request.StreetId = streetId;
        await Mediator.Send(request);
        return Ok();
    }
}