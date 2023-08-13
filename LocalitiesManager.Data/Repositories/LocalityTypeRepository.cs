using LocalitiesManager.Data.Entities;
using LocalitiesManager.Data.Repositories.Interfaces;

namespace LocalitiesManager.Data.Repositories;

public class LocalityTypeRepository : RepositoryBase<LocalityType>, ILocalityTypeRepository
{
    public LocalityTypeRepository(ApplicationDbContext context) : base(context)
    {
    }
}