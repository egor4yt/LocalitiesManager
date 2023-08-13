using System.ComponentModel.DataAnnotations;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Localities.CreateOne;

public class CreateOneLocalitiesCommandsRequest : IRequest<CreateOneLocalitiesCommandsResponse>
{
    [Required]
    public string Name { get; set; }

    [Required]
    public long LocalityTypeId { get; set; }
}