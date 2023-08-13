using System.ComponentModel.DataAnnotations;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Streets.CreateOne;

public class CreateOneStreetsCommandsRequest : IRequest<CreateOneStreetsCommandsResponse>
{
    [Required]
    public string Name { get; set; }

    [Required]
    public long StreetTypeId { get; set; }

    [Required]
    public long LocalityId { get; set; }
}