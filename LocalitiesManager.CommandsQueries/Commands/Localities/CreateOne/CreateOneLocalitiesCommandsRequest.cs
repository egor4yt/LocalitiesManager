using MediatR;

namespace LocalitiesManager.CommandsQueries.Commands.Localities.CreateOne;

public class CreateOneLocalitiesCommandsRequest : IRequest<CreateOneLocalitiesCommandsResponse>
{
    public string Name { get; set; }
    public long LocalityTypeId { get; set; }
}