using AutoMapper;
using LocalitiesManager.Data.Repositories.Interfaces;
using LocalitiesManager.Shared.Exceptions;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Apartments.UpdateOne;

public class UpdateOneApartmentsCommandsHandler : IRequestHandler<UpdateOneApartmentsCommandsRequest, UpdateOneApartmentsCommandsResponse>
{
    private readonly IApartmentRepository _apartmentRepository;
    private readonly IHouseRepository _houseRepository;
    private readonly IMapper _mapper;

    public UpdateOneApartmentsCommandsHandler(IMapper mapper, IApartmentRepository apartmentRepository, IHouseRepository houseRepository)
    {
        _mapper = mapper;
        _apartmentRepository = apartmentRepository;
        _houseRepository = houseRepository;
    }

    public async Task<UpdateOneApartmentsCommandsResponse> Handle(UpdateOneApartmentsCommandsRequest request, CancellationToken cancellationToken)
    {
        var houseExists = await _houseRepository.ExistsAsync(x => x.Id == request.HouseId);
        if (houseExists == false) throw new NotFoundException($"House with id {request.HouseId} not found");

        var apartment = await _apartmentRepository.FindFirstOrDefaultAsync(x => x.Id == request.ApartmentId);
        if (apartment is null) throw new NotFoundException($"Apartment with id {request.ApartmentId} not found");

        apartment.Number = request.Number;
        apartment.HouseId = request.HouseId;

        await _apartmentRepository.UpdateAsync(apartment);

        return _mapper.Map<UpdateOneApartmentsCommandsResponse>(apartment);
    }
}