using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Queries.Houses.Filter;

public class FilterHousesQueriesQuery : PageSettings, IRequest<FilterHousesQueriesResponse>
{
    public string Number { get; set; }
    public long LocalityId { get; set; }
    public long StreetId { get; set; }
}