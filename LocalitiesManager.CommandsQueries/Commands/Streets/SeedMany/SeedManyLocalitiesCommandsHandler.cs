using AutoMapper;
using AutoMapper.QueryableExtensions;
using LocalitiesManager.Data.Entities;
using LocalitiesManager.Data.Repositories.Interfaces;
using LocalitiesManager.Shared.Exceptions;
using MediatR;

namespace LocalitiesManager.CommandsQueries.Commands.Streets.SeedMany;

public class SeedManyLocalitiesCommandsHandler : IRequestHandler<SeedManyLocalitiesCommandsRequest, SeedManyLocalitiesCommandsResponse>
{
    private static readonly List<string> StreetNames = new() { "Юности", "Транспортников", "Светлогорская", "Красноярский рабочий", "Тверская", "50 лет октября", "9 мая", "Пушкина", "Гоголя", "Колосова", "Железнодорожников", "Партизанов", "Павлова", "Вавилова" };
    private readonly ILocalityRepository _localityRepository;
    private readonly IMapper _mapper;
    private readonly IStreetRepository _streetRepository;
    private readonly IStreetTypeRepository _streetTypeRepository;

    public SeedManyLocalitiesCommandsHandler(ILocalityRepository localityRepository, IMapper mapper, IStreetRepository streetRepository, IStreetTypeRepository streetTypeRepository)
    {
        _localityRepository = localityRepository;
        _mapper = mapper;
        _streetRepository = streetRepository;
        _streetTypeRepository = streetTypeRepository;
    }

    public async Task<SeedManyLocalitiesCommandsResponse> Handle(SeedManyLocalitiesCommandsRequest request, CancellationToken cancellationToken)
    {
        var response = new SeedManyLocalitiesCommandsResponse();
        var locality = await _localityRepository.FindFirstOrDefaultAsync(x => x.Id == request.LocalityId);
        if (locality is null) throw new NotFoundException($"Locality with id {request.LocalityId} not found");

        var allStreetTypes = await _streetTypeRepository.FindAllAsync(x => true);

        var streets = new List<Street>();
        for (var i = 0; i < request.CountOfNewStreets; i++)
        {
            var newStreet = new Street();
            newStreet.Name = StreetNames[new Random().Next(0, StreetNames.Count)];
            newStreet.StreetTypeId = allStreetTypes[new Random().Next(0, allStreetTypes.Count)].Id;
            newStreet.LocalityId = locality.Id;

            var localityCreated = await _streetRepository.ExistsAsync(x => x.Name == newStreet.Name && x.StreetTypeId == newStreet.LocalityId);
            if (localityCreated) continue;

            streets.Add(newStreet);
            await _streetRepository.InsertAsync(newStreet);
        }

        response.Items = streets.AsQueryable().ProjectTo<SeedManyLocalitiesCommandsStreetDto>(_mapper.ConfigurationProvider).ToList();

        return response;
    }
}