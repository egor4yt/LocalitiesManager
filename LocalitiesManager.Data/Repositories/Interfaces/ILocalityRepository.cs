using System.Linq.Expressions;
using LocalitiesManager.Data.Entities;

namespace LocalitiesManager.Data.Repositories.Interfaces;

public interface ILocalityRepository : IRepositoryBase<Locality>
{
    Task<Locality> FindFirstOrDefaultWithStreetsAsync(Expression<Func<Locality, bool>> match);
}