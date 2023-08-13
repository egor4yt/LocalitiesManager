using System.ComponentModel.DataAnnotations;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Streets.DeleteOne;

public class DeleteOneStreetsCommandsRequest : IRequest
{
    [Required]
    public long StreetId { get; set; }
}