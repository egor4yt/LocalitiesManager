using AutoMapper;
using LocalitiesManager.CommandsQueries.Mappings;
using LocalitiesManager.Data.Entities;

namespace LocalitiesManager.CommandsQueries.Commands.Streets.SeedMany;

public class SeedManyLocalitiesCommandsStreetDto: IMapWith<Street>
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Prefix { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Street, SeedManyLocalitiesCommandsStreetDto>()
            .ForMember(dest => dest.Name,
                opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Id,
                opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Prefix,
                opt => opt.MapFrom(src => src.StreetType.Prefix));
    }
}