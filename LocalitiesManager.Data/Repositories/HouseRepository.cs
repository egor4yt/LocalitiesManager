using System.Linq.Expressions;
using LocalitiesManager.Data.Entities;
using LocalitiesManager.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LocalitiesManager.Data.Repositories;

public class HouseRepository : RepositoryBase<House>, IHouseRepository
{
    public HouseRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<House> FindFirstOrDefaultWithApartmentsAsync(Expression<Func<House, bool>> match)
    {
        return await DbSet
            .Include(x => x.Apartments)
            .FirstOrDefaultAsync(match);
    }
}