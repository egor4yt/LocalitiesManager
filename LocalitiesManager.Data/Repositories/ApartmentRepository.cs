using System.Linq.Expressions;
using LocalitiesManager.Data.Entities;
using LocalitiesManager.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LocalitiesManager.Data.Repositories;

public class ApartmentRepository : RepositoryBase<Apartment>, IApartmentRepository
{
    public ApartmentRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<Apartment> FindFirstOrDefaultWithOwnersAsync(Expression<Func<Apartment, bool>> match)
    {
        return await DbSet
            .Include(x => x.Owners)
            .FirstOrDefaultAsync(match);
    }
}