using AutoMapper;
using LocalitiesManager.Api.CommandsQueries.Mappings;
using LocalitiesManager.Data.Entities;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Houses.CreateOne;

public class CreateOneHousesCommandsResponse : IMapWith<House>
{
    public long Id { get; set; }
    public string Number { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<House, CreateOneHousesCommandsResponse>()
            .ForMember(dest => dest.Number,
                opt => opt.MapFrom(src => src.Number))
            .ForMember(dest => dest.Id,
                opt => opt.MapFrom(src => src.Id));
    }
}