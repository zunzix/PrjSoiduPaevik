using App.DAL.Contracts;
using App.Domain;
using Base.DAL.EF;
using Microsoft.EntityFrameworkCore;

namespace App.DAL.EF.Repositories;


public class CarIssueRepository : BaseRepository<CarIssue>, ICarIssueRepository
{
    public CarIssueRepository(DbContext repositoryDbContext) : base(repositoryDbContext)
    {
    }

    public async Task<IEnumerable<CarIssue>> AllCarIssuesAsync(IEnumerable<Car> userCars)
    {
        var carIds = userCars.Select(g => g.Id).ToList();
        return await RepositoryDbSet
            .Include(c => c.Car)
            .Where(c => carIds.Contains(c.CarId))
            .ToListAsync();
    }
    
    public override async Task<CarIssue?> FindAsync(Guid id, Guid userId = default)
    {
        return await RepositoryDbSet
            .Include(c => c.Car)
            .FirstOrDefaultAsync(m => m.Id == id);
    }
}