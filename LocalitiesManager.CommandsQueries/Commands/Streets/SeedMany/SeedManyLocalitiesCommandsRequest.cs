using MediatR;

namespace LocalitiesManager.CommandsQueries.Commands.Streets.SeedMany;

public class SeedManyLocalitiesCommandsRequest : IRequest<SeedManyLocalitiesCommandsResponse>
{
    public int CountOfNewStreets { get; set; }
    public int LocalityId { get; set; }
}