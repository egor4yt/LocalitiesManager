using System.ComponentModel.DataAnnotations;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Streets.SeedMany;

public class SeedManyStreetsCommandsRequest : IRequest<SeedManyStreetsCommandsResponse>
{
    [Required]
    public int CountOfNewStreets { get; set; }

    [Required]
    public int LocalityId { get; set; }
}