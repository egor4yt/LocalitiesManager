using AutoMapper;
using LocalitiesManager.CommandsQueries.Mappings;
using LocalitiesManager.Data.Entities;

namespace LocalitiesManager.CommandsQueries.Commands.Localities.CreateOne;

public class CreateOneLocalitiesCommandsResponse : IMapWith<Locality>
{
    public long Id { get; set; }
    public string Name { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Locality, CreateOneLocalitiesCommandsResponse>()
            .ForMember(dest => dest.Name,
                opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Id,
            opt => opt.MapFrom(src => src.Id));
    }
}