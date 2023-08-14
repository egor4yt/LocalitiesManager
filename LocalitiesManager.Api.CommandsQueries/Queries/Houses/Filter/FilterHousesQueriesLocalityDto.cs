using AutoMapper;
using LocalitiesManager.Api.CommandsQueries.Mappings;
using LocalitiesManager.Data.Entities;

namespace LocalitiesManager.Api.CommandsQueries.Queries.Houses.Filter;

public class FilterHousesQueriesLocalityDto : IMapWith<House>
{
    public long Id { get; set; }
    public string Number { get; set; }
    public string StreetName { get; set; }
    public string StreetPrefix { get; set; }
    public string LocalityName { get; set; }
    public string LocalityPrefix { get; set; }
    public string ApartmentsCount { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<House, FilterHousesQueriesLocalityDto>()
            .ForMember(dest => dest.Number,
                opt => opt.MapFrom(src => src.Number))
            .ForMember(dest => dest.Id,
                opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.StreetName,
                opt => opt.MapFrom(src => src.Street.Name))
            .ForMember(dest => dest.StreetPrefix,
                opt => opt.MapFrom(src => src.Street.StreetType.Prefix))
            .ForMember(dest => dest.LocalityName,
                opt => opt.MapFrom(src => src.Street.Locality.Name))
            .ForMember(dest => dest.LocalityPrefix,
                opt => opt.MapFrom(src => src.Street.Locality.LocalityType.Prefix))
            .ForMember(dest => dest.ApartmentsCount,
                opt => opt.MapFrom(src => src.Apartments.Count));
    }
}