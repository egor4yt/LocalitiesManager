using LocalitiesManager.Api.CommandsQueries.Commands.Apartments.CreateOne;
using LocalitiesManager.Api.CommandsQueries.Commands.Apartments.DeleteOne;
using LocalitiesManager.Api.CommandsQueries.Commands.Apartments.UpdateOne;
using Microsoft.AspNetCore.Mvc;

namespace LocalitiesManager.Api.Controllers;

[Route("apartments")]
public class ApartmentsController : ApiControllerBase
{
    [HttpPost("create-one")]
    [ProducesResponseType(typeof(CreateOneApartmentsCommandsResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<CreateOneApartmentsCommandsResponse>> CreateOne([FromBody] CreateOneApartmentsCommandsRequest query)
    {
        var result = await Mediator.Send(query);
        return Ok(result);
    }

    [HttpPut("update/{apartmentId:long}")]
    [ProducesResponseType(typeof(UpdateOneApartmentsCommandsResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<UpdateOneApartmentsCommandsResponse>> UpdateOne([FromBody] UpdateOneApartmentsCommandsRequest request, [FromRoute] long apartmentId)
    {
        request.HouseId = apartmentId;
        var result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpDelete("delete/{apartmentId:long}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> DeleteOne([FromRoute] long apartmentId)
    {
        var request = new DeleteOneApartmentsCommandsRequest();
        request.ApartmentId = apartmentId;
        await Mediator.Send(request);
        return Ok();
    }
}