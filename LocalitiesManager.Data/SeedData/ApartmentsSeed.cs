using LocalitiesManager.Data.Entities;

namespace LocalitiesManager.Data.SeedData;

internal static class ApartmentsSeed
{
    public static IEnumerable<Apartment> Get(List<House> houses)
    {
        var apartments = new List<Apartment>();
        var lastId = 1;

        foreach (var house in houses)
        {
            for (var j = 0; j < new Random().Next(5,100); j++)
            {
                var newApartment = new Apartment();
                newApartment.Number = (j + 1).ToString();
                newApartment.HouseId = house.Id;
                newApartment.Id = lastId++;
                newApartment.CreatedAt = DateTime.UtcNow;

                apartments.Add(newApartment);
            }
        }

        return apartments;
    }
}