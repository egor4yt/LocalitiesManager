using LocalitiesManager.Data.Entities;
using LocalitiesManager.Data.Repositories.Interfaces;

namespace LocalitiesManager.Data.Repositories;

public class LocalityRepository : RepositoryBase<Locality>, ILocalityRepository
{
    public LocalityRepository(ApplicationDbContext context) : base(context)
    {
    }
}