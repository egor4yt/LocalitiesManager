using AutoMapper;
using AutoMapper.QueryableExtensions;
using LocalitiesManager.Data.Repositories.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LocalitiesManager.Api.CommandsQueries.Queries.Houses.Filter;

public class FilterHousesQueriesHandler : IRequestHandler<FilterHousesQueriesQuery, FilterHousesQueriesResponse>
{
    private readonly IHouseRepository _houseRepository;
    private readonly IMapper _mapper;

    public FilterHousesQueriesHandler(ILocalityRepository localityRepository, IMapper mapper, IHouseRepository houseRepository)
    {
        _mapper = mapper;
        _houseRepository = houseRepository;
    }

    public async Task<FilterHousesQueriesResponse> Handle(FilterHousesQueriesQuery request, CancellationToken cancellationToken)
    {
        var response = new FilterHousesQueriesResponse();

        var housesQuery = _houseRepository.AsQueryable();
        if (request.Skip > 0) housesQuery = housesQuery.Skip(request.Skip);
        if (string.IsNullOrWhiteSpace(request.Number) == false) housesQuery = housesQuery.Where(x => x.Number.ToLower().Contains(request.Number.ToLower()));
        if (request.StreetId != 0) housesQuery = housesQuery.Where(x => x.StreetId == request.StreetId);
        if (request.LocalityId != 0) housesQuery = housesQuery.Where(x => x.Street.LocalityId == request.LocalityId);
        if (request.Count > 0) housesQuery = housesQuery.Take(request.Count);

        response.Total = await housesQuery.LongCountAsync(cancellationToken);
        response.Items = await housesQuery
            .ProjectTo<FilterHousesQueriesLocalityDto>(_mapper.ConfigurationProvider)
            .OrderBy(x => x.LocalityName)
            .ThenBy(x=>x.LocalityName)
            .ThenBy(x=>x.ApartmentsCount)
            .ToListAsync(cancellationToken);

        return response;
    }
}