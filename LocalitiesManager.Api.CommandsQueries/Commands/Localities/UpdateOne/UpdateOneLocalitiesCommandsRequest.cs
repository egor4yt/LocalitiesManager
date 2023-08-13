using System.Text.Json.Serialization;
using MediatR;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Localities.UpdateOne;

public class UpdateOneLocalitiesCommandsRequest : IRequest<UpdateOneLocalitiesCommandsResponse>
{
    [JsonIgnore]
    public long LocalityId { get; set; }

    public string Name { get; set; }
    public long LocalityTypeId { get; set; }
}