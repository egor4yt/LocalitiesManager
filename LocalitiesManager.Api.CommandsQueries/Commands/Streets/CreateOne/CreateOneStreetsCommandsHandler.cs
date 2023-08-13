using AutoMapper;
using LocalitiesManager.Data.Entities;
using LocalitiesManager.Data.Repositories.Interfaces;
using LocalitiesManager.Shared.Exceptions;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Streets.CreateOne;

public class CreateOneStreetsCommandsHandler : IRequestHandler<CreateOneStreetsCommandsRequest, CreateOneStreetsCommandsResponse>
{
    private readonly ILocalityRepository _localityRepository;
    private readonly IMapper _mapper;
    private readonly IStreetRepository _streetRepository;
    private readonly IStreetTypeRepository _streetTypeRepository;


    public CreateOneStreetsCommandsHandler(IMapper mapper, IStreetRepository streetRepository, IStreetTypeRepository streetTypeRepository, ILocalityRepository localityRepository)
    {
        _mapper = mapper;
        _streetRepository = streetRepository;
        _streetTypeRepository = streetTypeRepository;
        _localityRepository = localityRepository;
    }

    public async Task<CreateOneStreetsCommandsResponse> Handle(CreateOneStreetsCommandsRequest request, CancellationToken cancellationToken)
    {
        var streetTypeExists = await _streetTypeRepository.ExistsAsync(x => x.Id == request.StreetTypeId);
        if (streetTypeExists == false) throw new NotFoundException($"Street type with id {request.StreetTypeId} does not exists");

        var localityExists = await _localityRepository.ExistsAsync(x => x.Id == request.LocalityId);
        if (localityExists == false) throw new NotFoundException($"Locality with id {request.LocalityId} not found");

        var street = new Street();
        street.CreatedAt = DateTime.UtcNow;
        street.Name = request.Name;
        street.StreetTypeId = request.StreetTypeId;
        street.LocalityId = request.LocalityId;

        await _streetRepository.InsertAsync(street);

        return _mapper.Map<CreateOneStreetsCommandsResponse>(street);
    }
}