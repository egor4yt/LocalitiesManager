using LocalitiesManager.Data.Entities;

namespace LocalitiesManager.Data.SeedData;

internal static class StreetTypesSeed
{
    public static IEnumerable<StreetType> Get()
    {
        return new List<StreetType>
        {
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 1,
                Name = "Улица",
                Prefix = "ул."
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 2,
                Name = "Переулок",
                Prefix = "пер."
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 3,
                Name = "Проспект",
                Prefix = "пр-кт."
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 4,
                Name = "Микрорайон",
                Prefix = "мкр."
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 5,
                Name = "Линия",
                Prefix = "л."
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 6,
                Name = "Дорога",
                Prefix = "дор."
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 7,
                Name = "Линия",
                Prefix = "лн."
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 8,
                Name = "Ряд",
                Prefix = "ряд"
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 9,
                Name = "Сквер",
                Prefix = "с-р"
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 10,
                Name = "Тракт",
                Prefix = "тракт"
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 11,
                Name = "Шоссе",
                Prefix = "ш."
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 12,
                Name = "Набережная",
                Prefix = "наб."
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 13,
                Name = "Магистраль",
                Prefix = "мгстр."
            }
        };
    }
}