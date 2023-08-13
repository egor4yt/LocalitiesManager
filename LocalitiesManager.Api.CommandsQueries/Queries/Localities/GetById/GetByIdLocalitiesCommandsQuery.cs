using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Queries.Localities.GetById;

public class GetByIdLocalitiesCommandsQuery : IRequest<GetByIdLocalitiesCommandsResponse>
{
    public long LocalityId { get; set; }
}