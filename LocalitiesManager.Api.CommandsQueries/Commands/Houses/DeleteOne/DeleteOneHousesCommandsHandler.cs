using LocalitiesManager.Data.Repositories.Interfaces;
using LocalitiesManager.Shared.Exceptions;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Houses.DeleteOne;

public class DeleteOneHousesCommandsHandler : IRequestHandler<DeleteOneHousesCommandsRequest>
{
    private readonly IHouseRepository _houseRepository;

    public DeleteOneHousesCommandsHandler(IHouseRepository houseRepository)
    {
        _houseRepository = houseRepository;
    }

    public async Task Handle(DeleteOneHousesCommandsRequest request, CancellationToken cancellationToken)
    {
        var house = await _houseRepository.FindFirstOrDefaultWithApartmentsAsync(x => x.Id == request.HouseId);
        if (house is null) throw new NotFoundException($"House with id {request.HouseId} not found");
        if (house.Apartments.Any()) throw new BadRequestException("Can't delete house with houses");

        await _houseRepository.DeleteAsync(house);
    }
}