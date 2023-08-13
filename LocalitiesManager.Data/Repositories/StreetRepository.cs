using LocalitiesManager.Data.Entities;
using LocalitiesManager.Data.Repositories.Interfaces;

namespace LocalitiesManager.Data.Repositories;

public class StreetRepository : RepositoryBase<Street>, IStreetRepository
{
    public StreetRepository(ApplicationDbContext context) : base(context)
    {
    }
}