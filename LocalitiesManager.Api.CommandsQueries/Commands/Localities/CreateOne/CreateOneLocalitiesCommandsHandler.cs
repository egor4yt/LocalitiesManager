using AutoMapper;
using LocalitiesManager.Data.Entities;
using LocalitiesManager.Data.Repositories.Interfaces;
using LocalitiesManager.Shared.Exceptions;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Localities.CreateOne;

public class CreateOneLocalitiesCommandsHandler : IRequestHandler<CreateOneLocalitiesCommandsRequest, CreateOneLocalitiesCommandsResponse>
{
    private readonly ILocalityRepository _localityRepository;
    private readonly ILocalityTypeRepository _localityTypeRepository;
    private readonly IMapper _mapper;

    public CreateOneLocalitiesCommandsHandler(ILocalityRepository localityRepository, IMapper mapper, ILocalityTypeRepository localityTypeRepository)
    {
        _localityRepository = localityRepository;
        _mapper = mapper;
        _localityTypeRepository = localityTypeRepository;
    }

    public async Task<CreateOneLocalitiesCommandsResponse> Handle(CreateOneLocalitiesCommandsRequest request, CancellationToken cancellationToken)
    {
        var localityTypeExists = await _localityTypeRepository.ExistsAsync(x => x.Id == request.LocalityTypeId);
        if (localityTypeExists == false) throw new NotFoundException($"Locality type with id {request.LocalityTypeId} does not exists");

        var locality = new Locality();
        locality.CreatedAt = DateTime.UtcNow;
        locality.Name = request.Name;
        locality.LocalityTypeId = request.LocalityTypeId;

        await _localityRepository.InsertAsync(locality);

        return _mapper.Map<CreateOneLocalitiesCommandsResponse>(locality);
    }
}