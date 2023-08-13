using LocalitiesManager.Data.Repositories.Interfaces;
using LocalitiesManager.Shared.Exceptions;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Apartments.DeleteOne;

public class DeleteOneApartmentsCommandsHandler : IRequestHandler<DeleteOneApartmentsCommandsRequest>
{
    private readonly IApartmentRepository _apartmentRepository;

    public DeleteOneApartmentsCommandsHandler(IApartmentRepository apartmentRepository)
    {
        _apartmentRepository = apartmentRepository;
    }

    public async Task Handle(DeleteOneApartmentsCommandsRequest request, CancellationToken cancellationToken)
    {
        var apartment = await _apartmentRepository.FindFirstOrDefaultWithOwnersAsync(x => x.Id == request.ApartmentId);
        if (apartment is null) throw new NotFoundException($"Apartment with id {request.ApartmentId} not found");
        if (apartment.Owners.Any()) throw new BadRequestException("Can't delete apartment with owners");

        await _apartmentRepository.DeleteAsync(apartment);
    }
}