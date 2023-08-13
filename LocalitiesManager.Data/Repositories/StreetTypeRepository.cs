using LocalitiesManager.Data.Entities;
using LocalitiesManager.Data.Repositories.Interfaces;

namespace LocalitiesManager.Data.Repositories;

public class StreetTypeRepository : RepositoryBase<StreetType>, IStreetTypeRepository
{
    public StreetTypeRepository(ApplicationDbContext context) : base(context)
    {
    }
}