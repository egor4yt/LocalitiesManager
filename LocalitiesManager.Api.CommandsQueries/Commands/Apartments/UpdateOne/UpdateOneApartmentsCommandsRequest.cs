using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Apartments.UpdateOne;

public class UpdateOneApartmentsCommandsRequest : IRequest<UpdateOneApartmentsCommandsResponse>
{
    [JsonIgnore]
    public long ApartmentId { get; set; }

    [Required]
    public long HouseId { get; set; }

    [Required]
    public string Number { get; set; }
}