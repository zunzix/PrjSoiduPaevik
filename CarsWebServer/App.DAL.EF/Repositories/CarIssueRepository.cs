using App.DAL.Contracts;
using App.DAL.EF.Mappers;
using App.Domain;
using Base.DAL.EF;
using Microsoft.EntityFrameworkCore;

namespace App.DAL.EF.Repositories;


public class CarIssueRepository : BaseRepository<App.DAL.DTO.CarIssue, App.Domain.CarIssue>, ICarIssueRepository
{
    public CarIssueRepository(AppDbContext repositoryDbContext) : base(repositoryDbContext, new CarIssueMapper())
    {
    }

    public async Task<IEnumerable<App.DAL.DTO.CarIssue>> AllCarIssuesAsync(IEnumerable<App.DAL.DTO.Car> userCars)
    {
        var carIds = userCars.Select(g => g.Id).ToList();
        return (await RepositoryDbSet
            .Include(c => c.Car)
            .Where(c => carIds.Contains(c.CarId))
            .ToListAsync()).Select(e => Mapper.Map(e)!);
    }
    
    public async Task<IEnumerable<App.DAL.DTO.CarIssue>> AllCarCarIssuesAsync(IEnumerable<App.DAL.DTO.CarIssue> userCarIssues, Guid carId)
    {
        return await Task.FromResult(userCarIssues.Where(c => c.CarId == carId));
    }
    
    public override async Task<App.DAL.DTO.CarIssue?> FindAsync(Guid id, Guid userId = default)
    {
        var res = await RepositoryDbSet
            .Include(c => c.Car)
            .Where(g => g.Car!.Group!.GroupMembers!.Any(gm => gm.UserId == userId))
            .FirstOrDefaultAsync(m => m.Id == id);
        return Mapper.Map(res);
    }
}