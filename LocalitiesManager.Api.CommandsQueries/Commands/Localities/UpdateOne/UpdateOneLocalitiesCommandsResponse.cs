using AutoMapper;
using LocalitiesManager.Api.CommandsQueries.Mappings;
using LocalitiesManager.Data.Entities;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Localities.UpdateOne;

public class UpdateOneLocalitiesCommandsResponse : IMapWith<Locality>
{
    public long Id { get; set; }
    public string Name { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Locality, UpdateOneLocalitiesCommandsResponse>()
            .ForMember(dest => dest.Name,
                opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Id,
                opt => opt.MapFrom(src => src.Id));
    }
}