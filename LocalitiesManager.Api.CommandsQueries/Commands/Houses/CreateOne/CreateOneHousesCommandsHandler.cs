using AutoMapper;
using LocalitiesManager.Data.Entities;
using LocalitiesManager.Data.Repositories.Interfaces;
using LocalitiesManager.Shared.Exceptions;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Houses.CreateOne;

public class CreateOneHousesCommandsHandler : IRequestHandler<CreateOneHousesCommandsRequest, CreateOneHousesCommandsResponse>
{
    private readonly IHouseRepository _houseRepository;
    private readonly IMapper _mapper;
    private readonly IStreetRepository _streetRepository;

    public CreateOneHousesCommandsHandler(IMapper mapper, IHouseRepository houseRepository, IStreetRepository streetRepository)
    {
        _mapper = mapper;
        _houseRepository = houseRepository;
        _streetRepository = streetRepository;
    }

    public async Task<CreateOneHousesCommandsResponse> Handle(CreateOneHousesCommandsRequest request, CancellationToken cancellationToken)
    {
        var streetExists = await _streetRepository.ExistsAsync(x => x.Id == request.StreetId);
        if (streetExists == false) throw new NotFoundException($"Street with id {request.StreetId} not found");

        var house = new House();
        house.CreatedAt = DateTime.UtcNow;
        house.Number = request.Number;
        house.StreetId = request.StreetId;

        await _houseRepository.InsertAsync(house);

        return _mapper.Map<CreateOneHousesCommandsResponse>(house);
    }
}