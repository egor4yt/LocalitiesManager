using AutoMapper;
using AutoMapper.QueryableExtensions;
using LocalitiesManager.Data.Repositories.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LocalitiesManager.CommandsQueries.Queries.Localities.Filter;

public class FilterLocalitiesQueriesHandler : IRequestHandler<FilterLocalitiesQueriesQuery, FilterLocalitiesQueriesResponse>
{
    private readonly ILocalityRepository _localityRepository;
    private readonly IMapper _mapper;

    public FilterLocalitiesQueriesHandler(ILocalityRepository localityRepository, IMapper mapper)
    {
        _localityRepository = localityRepository;
        _mapper = mapper;
    }

    public async Task<FilterLocalitiesQueriesResponse> Handle(FilterLocalitiesQueriesQuery request, CancellationToken cancellationToken)
    {
        var response = new FilterLocalitiesQueriesResponse();

        var localitiesQuery = _localityRepository.AsQueryable();
        if (request.Skip > 0) localitiesQuery = localitiesQuery.Skip(request.Skip);
        if (string.IsNullOrWhiteSpace(request.Name) == false) localitiesQuery = localitiesQuery.Where(x => x.Name.ToLower().Contains(request.Name.ToLower()));
        if (request.Count > 0) localitiesQuery = localitiesQuery.Take(request.Count);

        response.Total = await localitiesQuery.LongCountAsync(cancellationToken);
        response.Items = await localitiesQuery
            .ProjectTo<FilterLocalitiesQueriesLocalityDto>(_mapper.ConfigurationProvider)
            .OrderBy(x => x.Name)
            .ToListAsync(cancellationToken);

        return response;
    }
}