using LocalitiesManager.Data.Entities;

namespace LocalitiesManager.Data.SeedData;

internal static class StreetsSeed
{
    private static readonly List<string> StreetNames = new() { "Юности", "Транспортников", "Светлогорская", "Красноярский рабочий", "Тверская", "50 лет октября", "9 мая", "Пушкина", "Гоголя", "Колосова", "Железнодорожников", "Партизанов", "Павлова", "Вавилова", "Воеводова", "Голубева", "Осени" };
    public static IEnumerable<Street> Get(List<Locality> localities, List<StreetType> streetTypes)
    {
        var streets = new List<Street>();
        var lastId = 1;
        foreach (var locality in localities)
        {
            for (var j = 0; j < new Random().Next(5,11); j++)
            {
                var newStreet = new Street();
                newStreet.Name = StreetNames[new Random().Next(0, StreetNames.Count)];
                newStreet.StreetTypeId = streetTypes[new Random().Next(0, streetTypes.Count)].Id;
                newStreet.LocalityId = locality.Id;
                newStreet.Id = lastId++;
                newStreet.CreatedAt = DateTime.UtcNow;

                streets.Add(newStreet);
            }
        }

        return streets;
    }
}