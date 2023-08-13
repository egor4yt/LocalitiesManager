using System.Linq.Expressions;
using LocalitiesManager.Data.Entities;

namespace LocalitiesManager.Data.Repositories.Interfaces;

public interface IStreetRepository : IRepositoryBase<Street>
{
    public Task<Street> FindFirstOrDefaultWithHousesAsync(Expression<Func<Street, bool>> match);
}