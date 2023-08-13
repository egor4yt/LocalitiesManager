using AutoMapper;
using LocalitiesManager.Api.CommandsQueries.Mappings;
using LocalitiesManager.Data.Entities;

namespace LocalitiesManager.Api.CommandsQueries.Queries.Localities.GetById;

public class GetByIdLocalitiesCommandsResponse : IMapWith<Locality>
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string LocalityTypeId { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Locality, GetByIdLocalitiesCommandsResponse>()
            .ForMember(dest => dest.Name,
                opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Id,
                opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.LocalityTypeId,
                opt => opt.MapFrom(src => src.LocalityTypeId));
    }
}