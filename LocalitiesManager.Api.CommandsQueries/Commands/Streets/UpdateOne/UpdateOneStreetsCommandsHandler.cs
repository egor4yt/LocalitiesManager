using AutoMapper;
using LocalitiesManager.Data.Repositories.Interfaces;
using LocalitiesManager.Shared.Exceptions;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Streets.UpdateOne;

public class UpdateOneStreetsCommandsHandler : IRequestHandler<UpdateOneStreetsCommandsRequest, UpdateOneStreetsCommandsResponse>
{
    private readonly ILocalityRepository _localityRepository;
    private readonly IMapper _mapper;
    private readonly IStreetRepository _streetRepository;
    private readonly IStreetTypeRepository _streetTypeRepository;

    public UpdateOneStreetsCommandsHandler(ILocalityRepository localityRepository, IMapper mapper, IStreetRepository streetRepository, IStreetTypeRepository streetTypeRepository)
    {
        _localityRepository = localityRepository;
        _mapper = mapper;
        _streetRepository = streetRepository;
        _streetTypeRepository = streetTypeRepository;
    }

    public async Task<UpdateOneStreetsCommandsResponse> Handle(UpdateOneStreetsCommandsRequest request, CancellationToken cancellationToken)
    {
        var localityExists = await _localityRepository.ExistsAsync(x => x.Id == request.LocalityId);
        if (localityExists == false) throw new NotFoundException($"Locality with id {request.LocalityId} not found");

        var streetTypeExists = await _streetTypeRepository.ExistsAsync(x => x.Id == request.StreetTypeId);
        if (streetTypeExists == false) throw new NotFoundException($"Street type with id {request.StreetTypeId} does not exists");

        var street = await _streetRepository.FindFirstOrDefaultAsync(x => x.Id == request.StreetId);
        if (street is null) throw new NotFoundException($"Street with id {request.StreetId} not found");

        street.Name = request.Name;
        street.StreetTypeId = request.StreetTypeId;
        street.LocalityId = request.LocalityId;

        await _streetRepository.UpdateAsync(street);

        return _mapper.Map<UpdateOneStreetsCommandsResponse>(street);
    }
}