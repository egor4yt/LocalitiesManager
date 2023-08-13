using AutoMapper;
using LocalitiesManager.Data.Repositories.Interfaces;
using LocalitiesManager.Shared.Exceptions;
using MediatR;

namespace LocalitiesManager.CommandsQueries.Commands.Localities.DeleteOne;

public class DeleteOneLocalitiesCommandsHandler : IRequestHandler<DeleteOneLocalitiesCommandsRequest>
{
    private readonly ILocalityRepository _localityRepository;
    private readonly IMapper _mapper;

    public DeleteOneLocalitiesCommandsHandler(ILocalityRepository localityRepository, IMapper mapper)
    {
        _localityRepository = localityRepository;
        _mapper = mapper;
    }

    public async Task Handle(DeleteOneLocalitiesCommandsRequest request, CancellationToken cancellationToken)
    {
        var locality = await _localityRepository.FindFirstOrDefaultAsync(x => x.Id == request.LocalityId);
        if (locality is null) throw new NotFoundException($"Locality with id {request.LocalityId} not found");

        await _localityRepository.DeleteAsync(locality);
    }
}