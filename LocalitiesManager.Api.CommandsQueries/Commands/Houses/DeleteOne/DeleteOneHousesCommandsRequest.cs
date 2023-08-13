using System.ComponentModel.DataAnnotations;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Houses.DeleteOne;

public class DeleteOneHousesCommandsRequest : IRequest
{
    [Required]
    public long HouseId { get; set; }
}