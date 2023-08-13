using AutoMapper;
using LocalitiesManager.Data.Repositories.Interfaces;
using LocalitiesManager.Shared.Exceptions;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Queries.Streets.GetById;

public class GetByIdStreetsCommandsHandler : IRequestHandler<GetByIdStreetsCommandsQuery, GetByIdStreetsCommandsResponse>
{
    private readonly IMapper _mapper;
    private readonly IStreetRepository _streetRepository;

    public GetByIdStreetsCommandsHandler(IMapper mapper, IStreetRepository streetRepository)
    {
        _mapper = mapper;
        _streetRepository = streetRepository;
    }

    public async Task<GetByIdStreetsCommandsResponse> Handle(GetByIdStreetsCommandsQuery query, CancellationToken cancellationToken)
    {
        var street = await _streetRepository.FindFirstOrDefaultAsync(x => x.Id == query.StreetId);
        if (street is null) throw new NotFoundException($"Street with id {query.StreetId} not found");

        return _mapper.Map<GetByIdStreetsCommandsResponse>(street);
    }
}