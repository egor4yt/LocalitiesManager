using AutoMapper;
using LocalitiesManager.Data.Repositories.Interfaces;
using LocalitiesManager.Shared.Exceptions;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Localities.UpdateOne;

public class UpdateOneLocalitiesCommandsHandler : IRequestHandler<UpdateOneLocalitiesCommandsRequest, UpdateOneLocalitiesCommandsResponse>
{
    private readonly ILocalityRepository _localityRepository;
    private readonly ILocalityTypeRepository _localityTypeRepository;
    private readonly IMapper _mapper;

    public UpdateOneLocalitiesCommandsHandler(ILocalityRepository localityRepository, IMapper mapper, ILocalityTypeRepository localityTypeRepository)
    {
        _localityRepository = localityRepository;
        _mapper = mapper;
        _localityTypeRepository = localityTypeRepository;
    }

    public async Task<UpdateOneLocalitiesCommandsResponse> Handle(UpdateOneLocalitiesCommandsRequest request, CancellationToken cancellationToken)
    {
        var locality = await _localityRepository.FindFirstOrDefaultAsync(x => x.Id == request.LocalityId);
        if (locality is null) throw new NotFoundException($"Locality with id {request.LocalityId} not found");

        var localityTypeExists = await _localityTypeRepository.ExistsAsync(x => x.Id == request.LocalityTypeId);
        if (localityTypeExists == false) throw new NotFoundException($"Locality type with id {request.LocalityTypeId} does not exists");

        locality.Name = request.Name;
        locality.LocalityTypeId = request.LocalityTypeId;

        await _localityRepository.UpdateAsync(locality);

        return _mapper.Map<UpdateOneLocalitiesCommandsResponse>(locality);
    }
}