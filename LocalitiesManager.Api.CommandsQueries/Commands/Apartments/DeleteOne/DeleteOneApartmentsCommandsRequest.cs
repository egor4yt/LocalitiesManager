using System.ComponentModel.DataAnnotations;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Apartments.DeleteOne;

public class DeleteOneApartmentsCommandsRequest : IRequest
{
    [Required]
    public long ApartmentId { get; set; }
}