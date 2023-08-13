using System.ComponentModel.DataAnnotations;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Apartments.CreateOne;

public class CreateOneApartmentsCommandsRequest : IRequest<CreateOneApartmentsCommandsResponse>
{
    [Required]
    public string Number { get; set; }

    [Required]
    public long HouseId { get; set; }
    
    [Required]
    public long OwnerId { get; set; }
}