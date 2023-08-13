using AutoMapper;
using LocalitiesManager.Data.Repositories.Interfaces;
using LocalitiesManager.Shared.Exceptions;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Houses.UpdateOne;

public class UpdateOneHousesCommandsHandler : IRequestHandler<UpdateOneHousesCommandsRequest, UpdateOneHousesCommandsResponse>
{
    private readonly IHouseRepository _houseRepository;
    private readonly IMapper _mapper;
    private readonly IStreetRepository _streetRepository;

    public UpdateOneHousesCommandsHandler(IMapper mapper, IStreetRepository streetRepository, IHouseRepository houseRepository)
    {
        _mapper = mapper;
        _streetRepository = streetRepository;
        _houseRepository = houseRepository;
    }

    public async Task<UpdateOneHousesCommandsResponse> Handle(UpdateOneHousesCommandsRequest request, CancellationToken cancellationToken)
    {
        var streetExists = await _streetRepository.ExistsAsync(x => x.Id == request.StreetId);
        if (streetExists == false) throw new NotFoundException($"Street with id {request.StreetId} not found");

        var house = await _houseRepository.FindFirstOrDefaultAsync(x => x.Id == request.HouseId);
        if (house is null) throw new NotFoundException($"House with id {request.HouseId} not found");

        house.Number = request.Number;
        house.StreetId = request.StreetId;

        await _houseRepository.UpdateAsync(house);

        return _mapper.Map<UpdateOneHousesCommandsResponse>(house);
    }
}