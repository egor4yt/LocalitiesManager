using AutoMapper;
using LocalitiesManager.Data.Repositories.Interfaces;
using LocalitiesManager.Shared.Exceptions;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Streets.DeleteOne;

public class DeleteOneStreetsCommandsHandler : IRequestHandler<DeleteOneStreetsCommandsRequest>
{
    private readonly IMapper _mapper;
    private readonly IStreetRepository _streetRepository;

    public DeleteOneStreetsCommandsHandler(IMapper mapper, IStreetRepository streetRepository)
    {
        _mapper = mapper;
        _streetRepository = streetRepository;
    }

    public async Task Handle(DeleteOneStreetsCommandsRequest request, CancellationToken cancellationToken)
    {
        var street = await _streetRepository.FindFirstOrDefaultWithHousesAsync(x => x.Id == request.StreetId);
        if (street is null) throw new NotFoundException($"Street with id {request.StreetId} not found");
        if (street.Houses.Any()) throw new BadRequestException("Can't delete street with houses");

        await _streetRepository.DeleteAsync(street);
    }
}