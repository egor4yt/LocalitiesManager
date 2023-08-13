using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Localities.UpdateOne;

public class UpdateOneLocalitiesCommandsRequest : IRequest<UpdateOneLocalitiesCommandsResponse>
{
    [JsonIgnore]
    public long LocalityId { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public long LocalityTypeId { get; set; }
}