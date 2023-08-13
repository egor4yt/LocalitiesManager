using AutoMapper;
using LocalitiesManager.Data.Repositories.Interfaces;
using LocalitiesManager.Shared.Exceptions;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Queries.Localities.GetById;

public class GetByIdLocalitiesCommandsHandler : IRequestHandler<GetByIdLocalitiesCommandsQuery, GetByIdLocalitiesCommandsResponse>
{
    private readonly ILocalityRepository _localityRepository;
    private readonly IMapper _mapper;

    public GetByIdLocalitiesCommandsHandler(ILocalityRepository localityRepository, IMapper mapper)
    {
        _localityRepository = localityRepository;
        _mapper = mapper;
    }

    public async Task<GetByIdLocalitiesCommandsResponse> Handle(GetByIdLocalitiesCommandsQuery query, CancellationToken cancellationToken)
    {
        var locality = await _localityRepository.FindFirstOrDefaultAsync(x => x.Id == query.LocalityId);
        if (locality is null) throw new NotFoundException($"Locality with id {query.LocalityId} not found");

        return _mapper.Map<GetByIdLocalitiesCommandsResponse>(locality);
    }
}