using AutoMapper;
using LocalitiesManager.Api.CommandsQueries.Mappings;
using LocalitiesManager.Data.Entities;

namespace LocalitiesManager.Api.CommandsQueries.Queries.Streets.GetById;

public class GetByIdStreetsCommandsResponse : IMapWith<Street>
{
    public long Id { get; set; }
    public string Name { get; set; }
    public long StreetTypeId { get; set; }
    public long LocalityId { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Street, GetByIdStreetsCommandsResponse>()
            .ForMember(dest => dest.Name,
                opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Id,
                opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.StreetTypeId,
                opt => opt.MapFrom(src => src.StreetTypeId))
            .ForMember(dest => dest.LocalityId,
                opt => opt.MapFrom(src => src.LocalityId));
    }
}