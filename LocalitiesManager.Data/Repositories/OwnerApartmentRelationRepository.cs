using LocalitiesManager.Data.Entities;
using LocalitiesManager.Data.Repositories.Interfaces;

namespace LocalitiesManager.Data.Repositories;

public class OwnerApartmentRelationRepository : RepositoryBase<OwnerApartmentRelation>, IOwnerApartmentRelationRepository
{
    public OwnerApartmentRelationRepository(ApplicationDbContext context) : base(context)
    {
    }
}