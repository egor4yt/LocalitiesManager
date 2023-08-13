using System.Linq.Expressions;
using LocalitiesManager.Data.Entities;

namespace LocalitiesManager.Data.Repositories.Interfaces;

public interface ILocalityRepository : IRepositoryBase<Locality>
{
    public Task<Locality> FindFirstOrDefaultWithStreetsAsync(Expression<Func<Locality, bool>> match);
}