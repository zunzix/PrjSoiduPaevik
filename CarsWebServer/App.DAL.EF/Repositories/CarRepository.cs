using App.DAL.Contracts;
using App.Domain;
using Base.DAL.EF;
using Microsoft.EntityFrameworkCore;

namespace App.DAL.EF.Repositories;

public class CarRepository : BaseRepository<Car>, ICarRepository
{
    public CarRepository(DbContext repositoryDbContext) : base(repositoryDbContext)
    {
    }
    
    public async Task<IEnumerable<Car>> AllCars(
        IEnumerable<Group> userGroups,
        Guid userId = default) 
    {
        var groupIds = userGroups.Select(g => g.Id).ToList();
        return await RepositoryDbSet
            .Include(c => c.Group)
            .Where(c => groupIds.Contains(c.GroupId))
            .ToListAsync();
    }
    
    public override async Task<Car?> FindAsync(Guid id, Guid userId = default)
    {
        return await RepositoryDbSet
            .Include(c => c.Group)
            .FirstOrDefaultAsync(m => m.Id == id);
    }
}