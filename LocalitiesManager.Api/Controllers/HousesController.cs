using LocalitiesManager.Api.CommandsQueries.Commands.Houses.CreateOne;
using LocalitiesManager.Api.CommandsQueries.Commands.Houses.DeleteOne;
using LocalitiesManager.Api.CommandsQueries.Commands.Houses.UpdateOne;
using Microsoft.AspNetCore.Mvc;

namespace LocalitiesManager.Api.Controllers;

[Route("houses")]
public class HousesController : ApiControllerBase
{
    [HttpPost("create-one")]
    [ProducesResponseType(typeof(CreateOneHousesCommandsResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<ActionResult<CreateOneHousesCommandsResponse>> CreateOne([FromBody] CreateOneHousesCommandsRequest query)
    {
        var result = await Mediator.Send(query);
        return Ok(result);
    }

    [HttpPut("update/{houseId:long}")]
    [ProducesResponseType(typeof(UpdateOneHousesCommandsResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<UpdateOneHousesCommandsResponse>> UpdateOne([FromBody] UpdateOneHousesCommandsRequest request, [FromRoute] long houseId)
    {
        request.HouseId = houseId;
        var result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpDelete("delete/{houseId:long}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> DeleteOne([FromRoute] long houseId)
    {
        var request = new DeleteOneHousesCommandsRequest();
        request.HouseId = houseId;
        await Mediator.Send(request);
        return Ok();
    }
}