using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Queries.Streets.GetById;

public class GetByIdStreetsCommandsQuery : IRequest<GetByIdStreetsCommandsResponse>
{
    public long StreetId { get; set; }
}