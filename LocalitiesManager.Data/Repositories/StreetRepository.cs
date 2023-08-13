using System.Linq.Expressions;
using LocalitiesManager.Data.Entities;
using LocalitiesManager.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LocalitiesManager.Data.Repositories;

public class StreetRepository : RepositoryBase<Street>, IStreetRepository
{
    public StreetRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<Street> FindFirstOrDefaultWithHousesAsync(Expression<Func<Street, bool>> match)
    {
        return await DbSet
            .Include(x => x.Houses)
            .FirstOrDefaultAsync(match);
    }
}