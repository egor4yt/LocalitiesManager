using System.Linq.Expressions;
using LocalitiesManager.Data.Entities;

namespace LocalitiesManager.Data.Repositories.Interfaces;

public interface IHouseRepository : IRepositoryBase<House>
{
    public Task<House> FindFirstOrDefaultWithApartmentsAsync(Expression<Func<House, bool>> match);
}