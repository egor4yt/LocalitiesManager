using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Houses.UpdateOne;

public class UpdateOneHousesCommandsRequest : IRequest<UpdateOneHousesCommandsResponse>
{
    [JsonIgnore]
    public long HouseId { get; set; }

    [Required]
    public long StreetId { get; set; }

    [Required]
    public string Number { get; set; }
}