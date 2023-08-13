using System.Linq.Expressions;
using LocalitiesManager.Data.Entities;

namespace LocalitiesManager.Data.Repositories.Interfaces;

public interface IApartmentRepository : IRepositoryBase<Apartment>
{
    Task<Apartment> FindFirstOrDefaultWithOwnersAsync(Expression<Func<Apartment, bool>> match);
}