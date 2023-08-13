using MediatR;

namespace LocalitiesManager.CommandsQueries.Commands.Localities.DeleteOne;

public class DeleteOneLocalitiesCommandsRequest : IRequest
{
    public long LocalityId { get; set; }
}