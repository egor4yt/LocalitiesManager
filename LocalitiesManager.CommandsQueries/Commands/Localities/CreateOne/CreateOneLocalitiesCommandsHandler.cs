using AutoMapper;
using LocalitiesManager.Data.Entities;
using LocalitiesManager.Data.Repositories.Interfaces;
using MediatR;

namespace LocalitiesManager.CommandsQueries.Commands.Localities.CreateOne;

public class CreateOneLocalitiesCommandsHandler : IRequestHandler<CreateOneLocalitiesCommandsRequest, CreateOneLocalitiesCommandsResponse>
{
    private readonly ILocalityRepository _localityRepository;
    private readonly IMapper _mapper;

    public CreateOneLocalitiesCommandsHandler(ILocalityRepository localityRepository, IMapper mapper)
    {
        _localityRepository = localityRepository;
        _mapper = mapper;
    }

    public async Task<CreateOneLocalitiesCommandsResponse> Handle(CreateOneLocalitiesCommandsRequest request, CancellationToken cancellationToken)
    {
        var locality = new Locality
        {
            CreatedAt = DateTime.UtcNow,
            Name = request.Name,
            LocalityTypeId = request.LocalityTypeId
        };

        await _localityRepository.InsertAsync(locality);

        return _mapper.Map<CreateOneLocalitiesCommandsResponse>(locality);
    }
}