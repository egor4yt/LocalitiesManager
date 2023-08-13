using LocalitiesManager.Data.Entities;

namespace LocalitiesManager.Data.SeedData;

internal static class LocalitiesSeed
{
    public static IEnumerable<Locality> Get()
    {
        return new List<Locality>
        {
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 1,
                Name = "Красноярск",
                LocalityTypeId = 1
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 2,
                Name = "Ачинск",
                LocalityTypeId = 1
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 3,
                Name = "Лесосибирск",
                LocalityTypeId = 1
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 4,
                Name = "Шарыпово",
                LocalityTypeId = 1
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 5,
                Name = "Дивногорск",
                LocalityTypeId = 1
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 6,
                Name = "Сосновоборск",
                LocalityTypeId = 1
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 7,
                Name = "Ужур",
                LocalityTypeId = 1
            }
        };
    }
}