using LocalitiesManager.Data.Entities;
using LocalitiesManager.Data.Repositories.Interfaces;

namespace LocalitiesManager.Data.Repositories;

public class ApartmentRepository : RepositoryBase<Apartment>, IApartmentRepository
{
    public ApartmentRepository(ApplicationDbContext context) : base(context)
    {
    }
}