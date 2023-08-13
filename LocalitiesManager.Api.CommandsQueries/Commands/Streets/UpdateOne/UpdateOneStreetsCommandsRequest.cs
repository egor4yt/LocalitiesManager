using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Streets.UpdateOne;

public class UpdateOneStreetsCommandsRequest : IRequest<UpdateOneStreetsCommandsResponse>
{
    [JsonIgnore]
    public long StreetId { get; set; }

    [Required]
    public long LocalityId { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public long StreetTypeId { get; set; }
}