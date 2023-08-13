using LocalitiesManager.Data.Entities;

namespace LocalitiesManager.Data.SeedData;

internal static class OwnersSeed
{
    public static IEnumerable<Owner> Get()
    {
        return new List<Owner>
        {
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 1,
                LastName = "Ермаков",
                FirstName = "Егор",
                Surname = "Дмитриевич"
            },
            new()
            {
                CreatedAt = DateTime.UtcNow,
                Id = 2,
                LastName = "Пушкин",
                FirstName = "Сергей",
                Surname = "Викторович"
            }
        };
    }
}