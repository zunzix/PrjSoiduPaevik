using App.DAL.Contracts;
using App.Domain;
using Base.DAL.EF;
using Microsoft.EntityFrameworkCore;

namespace App.DAL.EF.Repositories;

public class CarLogRepository : BaseRepository<CarLog>, ICarLogRepository
{
    public CarLogRepository(DbContext repositoryDbContext) : base(repositoryDbContext)
    {
    }

    public async Task<IEnumerable<CarLog>> AllCarLogsAsync(
        IEnumerable<Car> userCars)
    {
        var carIds = userCars.Select(g => g.Id).ToList();
        return await RepositoryDbSet
            .Include(c => c.Car)
            .Include(c => c.User)
            .Where(c => carIds.Contains(c.CarId))
            .ToListAsync();
    }
    
    public override async Task<CarLog?> FindAsync(Guid id, Guid userId = default)
    {
        return await RepositoryDbSet
            .Include(c => c.User)
            .Include(c => c.Car)
            .FirstOrDefaultAsync(m => m.Id == id);
    }
}