using System.ComponentModel.DataAnnotations;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Houses.CreateOne;

public class CreateOneHousesCommandsRequest : IRequest<CreateOneHousesCommandsResponse>
{
    [Required]
    public string Number { get; set; }

    [Required]
    public long StreetId { get; set; }
}