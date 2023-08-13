using LocalitiesManager.Data.Entities;

namespace LocalitiesManager.Data.SeedData;

internal static class LocalityTypesSeed
{
    public static IEnumerable<LocalityType> Get()
    {
        return new List<LocalityType>
        {
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 1,
                Name = "Город",
                Prefix = "г."
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 2,
                Name = "Посёлок",
                Prefix = "п."
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 3,
                Name = "Посёлок городского типа",
                Prefix = "пгт."
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 4,
                Name = "Деревня",
                Prefix = "д."
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 5,
                Name = "Село",
                Prefix = "с."
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 6,
                Name = "Рабочий посёлок",
                Prefix = "рп."
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 7,
                Name = "Курортный посёлок",
                Prefix = "кп."
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 8,
                Name = "Кишлак",
                Prefix = "к."
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 9,
                Name = "Дачный посёлок",
                Prefix = "дп."
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 10,
                Name = "Посёлок при станции",
                Prefix = "п.ст."
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 11,
                Name = "Местечко",
                Prefix = "м."
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 12,
                Name = "Слобода",
                Prefix = "сл."
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 13,
                Name = "Станция",
                Prefix = "ст."
            }
        };
    }
}