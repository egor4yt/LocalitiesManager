using AutoMapper;
using LocalitiesManager.Data.Entities;
using LocalitiesManager.Data.Repositories.Interfaces;
using LocalitiesManager.Shared.Exceptions;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Apartments.CreateOne;

public class CreateOneApartmentsCommandsHandler : IRequestHandler<CreateOneApartmentsCommandsRequest, CreateOneApartmentsCommandsResponse>
{
    private readonly IApartmentRepository _apartmentRepository;
    private readonly IHouseRepository _houseRepository;
    private readonly IMapper _mapper;
    private readonly IOwnerRepository _ownerRepository;

    public CreateOneApartmentsCommandsHandler(IMapper mapper, IApartmentRepository apartmentRepository, IHouseRepository houseRepository, IOwnerRepository ownerRepository)
    {
        _mapper = mapper;
        _apartmentRepository = apartmentRepository;
        _houseRepository = houseRepository;
        _ownerRepository = ownerRepository;
    }

    public async Task<CreateOneApartmentsCommandsResponse> Handle(CreateOneApartmentsCommandsRequest request, CancellationToken cancellationToken)
    {
        var houseExists = await _houseRepository.ExistsAsync(x => x.Id == request.HouseId);
        if (houseExists == false) throw new NotFoundException($"House with id {request.HouseId} not found");

        var owner = await _ownerRepository.FindFirstOrDefaultAsync(x => x.Id == request.OwnerId);
        if (owner is null) throw new NotFoundException($"Owner with id {request.OwnerId} not found");

        var apartment = new Apartment();
        apartment.CreatedAt = DateTime.UtcNow;
        apartment.Number = request.Number;
        apartment.HouseId = request.HouseId;
        apartment.Owners = new List<Owner>();
        apartment.Owners.Add(owner);

        await _apartmentRepository.InsertAsync(apartment);

        return _mapper.Map<CreateOneApartmentsCommandsResponse>(apartment);
    }
}