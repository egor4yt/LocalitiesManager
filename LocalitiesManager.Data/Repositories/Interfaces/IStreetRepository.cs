using System.Linq.Expressions;
using LocalitiesManager.Data.Entities;

namespace LocalitiesManager.Data.Repositories.Interfaces;

public interface IStreetRepository : IRepositoryBase<Street>
{
    Task<Street> FindFirstOrDefaultWithHousesAsync(Expression<Func<Street, bool>> match);
}