using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Localities.DeleteOne;

public class DeleteOneLocalitiesCommandsRequest : IRequest
{
    public long LocalityId { get; set; }
}