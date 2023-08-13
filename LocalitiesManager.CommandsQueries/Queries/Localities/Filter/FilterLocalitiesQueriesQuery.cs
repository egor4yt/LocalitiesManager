using MediatR;

namespace LocalitiesManager.CommandsQueries.Queries.Localities.Filter;

public class FilterLocalitiesQueriesQuery : PageSettings, IRequest<FilterLocalitiesQueriesResponse>
{
    public string Name { get; set; }
}