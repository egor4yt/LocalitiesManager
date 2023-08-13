using AutoMapper;

namespace LocalitiesManager.Api.CommandsQueries.Mappings;

public interface IMapWith<T>
{
    void Mapping(Profile profile)
    {
        profile.CreateMap(typeof(T), GetType());
    }
}