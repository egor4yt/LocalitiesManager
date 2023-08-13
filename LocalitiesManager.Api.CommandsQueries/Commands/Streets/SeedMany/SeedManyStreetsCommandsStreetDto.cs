using AutoMapper;
using LocalitiesManager.Api.CommandsQueries.Mappings;
using LocalitiesManager.Data.Entities;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Streets.SeedMany;

public class SeedManyStreetsCommandsStreetDto : IMapWith<Street>
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Prefix { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Street, SeedManyStreetsCommandsStreetDto>()
            .ForMember(dest => dest.Name,
                opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Id,
                opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Prefix,
                opt => opt.MapFrom(src => src.StreetType.Prefix));
    }
}