using System.Linq.Expressions;
using LocalitiesManager.Data.Entities;
using LocalitiesManager.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LocalitiesManager.Data.Repositories;

public class LocalityRepository : RepositoryBase<Locality>, ILocalityRepository
{
    public LocalityRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<Locality> FindFirstOrDefaultWithStreetsAsync(Expression<Func<Locality, bool>> match)
    {
        return await DbSet
            .Include(x=>x.Streets)
            .FirstOrDefaultAsync(match);
    }
}