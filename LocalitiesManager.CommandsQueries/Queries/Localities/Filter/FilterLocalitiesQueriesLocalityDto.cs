using AutoMapper;
using LocalitiesManager.CommandsQueries.Mappings;
using LocalitiesManager.Data.Entities;

namespace LocalitiesManager.CommandsQueries.Queries.Localities.Filter;

public class FilterLocalitiesQueriesLocalityDto : IMapWith<Locality>
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Prefix { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Locality, FilterLocalitiesQueriesLocalityDto>()
            .ForMember(dest => dest.Name,
                opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Id,
                opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Prefix,
                opt => opt.MapFrom(src => src.LocalityType.Prefix));
    }
}