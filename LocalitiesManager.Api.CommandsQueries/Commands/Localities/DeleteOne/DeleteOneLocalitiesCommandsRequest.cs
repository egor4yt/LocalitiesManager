using System.ComponentModel.DataAnnotations;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Localities.DeleteOne;

public class DeleteOneLocalitiesCommandsRequest : IRequest
{
    [Required]
    public long LocalityId { get; set; }
}