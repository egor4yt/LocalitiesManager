using LocalitiesManager.Data.Entities;
using LocalitiesManager.Data.Repositories.Interfaces;

namespace LocalitiesManager.Data.Repositories;

public class HouseRepository : RepositoryBase<House>, IHouseRepository
{
    public HouseRepository(ApplicationDbContext context) : base(context)
    {
    }
}