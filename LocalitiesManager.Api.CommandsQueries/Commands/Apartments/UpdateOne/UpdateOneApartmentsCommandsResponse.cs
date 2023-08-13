using AutoMapper;
using LocalitiesManager.Api.CommandsQueries.Mappings;
using LocalitiesManager.Data.Entities;

namespace LocalitiesManager.Api.CommandsQueries.Commands.Apartments.UpdateOne;

public class UpdateOneApartmentsCommandsResponse : IMapWith<Apartment>
{
    public long Id { get; set; }
    public string Number { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Apartment, UpdateOneApartmentsCommandsResponse>()
            .ForMember(dest => dest.Number,
                opt => opt.MapFrom(src => src.Number))
            .ForMember(dest => dest.Id,
                opt => opt.MapFrom(src => src.Id));
    }
}