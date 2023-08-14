using LocalitiesManager.Data.Entities;

namespace LocalitiesManager.Data.SeedData;

internal static class HousesSeed
{
    public static IEnumerable<House> Get(List<Street> streets)
    {
        var houses = new List<House>();
        var lastId = 1;

        foreach (var street in streets)
        {
            for (var j = 0; j < new Random().Next(10,20); j++)
            {
                var newHouse = new House();
                newHouse.Number = (j + 1).ToString();
                newHouse.StreetId = street.Id;
                newHouse.Id = lastId++;
                newHouse.CreatedAt = DateTime.UtcNow;

                houses.Add(newHouse);
            }
        }

        return houses;
    }
}