using System.Linq.Expressions;
using LocalitiesManager.Data.Entities;

namespace LocalitiesManager.Data.Repositories.Interfaces;

public interface IHouseRepository : IRepositoryBase<House>
{
    Task<House> FindFirstOrDefaultWithApartmentsAsync(Expression<Func<House, bool>> match);
}