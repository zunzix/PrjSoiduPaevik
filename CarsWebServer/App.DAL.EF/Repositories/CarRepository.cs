using App.DAL.Contracts;
using App.DAL.EF.Mappers;
using App.Domain;
using Base.DAL.EF;
using Microsoft.EntityFrameworkCore;

namespace App.DAL.EF.Repositories;

public class CarRepository : BaseRepository<App.DAL.DTO.Car, App.Domain.Car>, ICarRepository
{
    public CarRepository(AppDbContext repositoryDbContext) : base(repositoryDbContext, new CarMapper(repositoryDbContext))
    {
    }
    
    public async Task<IEnumerable<App.DAL.DTO.Car>> AllCarsAsync(
        IEnumerable<App.DAL.DTO.Group> userGroups) 
    {
        var groupIds = userGroups.Select(g => g.Id).ToList();
        return (await RepositoryDbSet
            .Include(c => c.Group)
            .Where(c => groupIds.Contains(c.GroupId))
            .ToListAsync()).Select(e => Mapper.Map(e)!);
    }
    
    public async Task<IEnumerable<App.DAL.DTO.Car>> AllGroupCarsAsync(IEnumerable<App.DAL.DTO.Car> userCars, Guid groupId) 
    {
        return await Task.FromResult(userCars.Where(c => c.GroupId == groupId));
    }

    public IEnumerable<App.DAL.DTO.Car> AllCars(IEnumerable<App.DAL.DTO.Group> userGroups)
    {
        var groupIds = userGroups.Select(g => g.Id).ToList();
        return RepositoryDbSet
            .Include(c => c.Group)
            .Where(c => groupIds.Contains(c.GroupId))
            .ToList().Select(e => Mapper.Map(e)!);
    }

    public override async Task<App.DAL.DTO.Car?> FindAsync(Guid id, Guid userId = default)
    {
        var res = await RepositoryDbSet
            .Include(c => c.Group)
            .Where(g => g.Group!.GroupMembers!.Any(gm => gm.UserId == userId))
            .FirstOrDefaultAsync(m => m.Id == id);
        return Mapper.Map(res);
    }
    
    public void RemoveCarWithDependencies(App.DAL.DTO.Car entity)
    {
        var domainEntity = Mapper.Map(entity)!;
        var carId = domainEntity.Id;

        // Delete car-related
        RepositoryDbContext.Set<CarIssue>()
            .RemoveRange(RepositoryDbContext.Set<CarIssue>()
                .Where(ci => ci.CarId == carId));

        RepositoryDbContext.Set<CarLog>()
            .RemoveRange(RepositoryDbContext.Set<CarLog>()
                .Where(cl => cl.CarId == carId));

        RepositoryDbContext.Set<CarInsurance>()
            .RemoveRange(RepositoryDbContext.Set<CarInsurance>()
                .Where(ci => ci.CarId == carId));

        // Delete car
        RepositoryDbContext.Set<Car>()
            .Remove(domainEntity);
    }
    
    public async Task RemoveCarWithDependenciesAsync(App.DAL.DTO.Car entity)
    {
        var domainEntity = Mapper.Map(entity)!;
        var carId = domainEntity.Id;

        // Delete car-related entities asynchronously
        var carIssues = await RepositoryDbContext.Set<CarIssue>()
            .Where(ci => ci.CarId == carId)
            .ToListAsync();
        RepositoryDbContext.Set<CarIssue>().RemoveRange(carIssues);

        var carLogs = await RepositoryDbContext.Set<CarLog>()
            .Where(cl => cl.CarId == carId)
            .ToListAsync();
        RepositoryDbContext.Set<CarLog>().RemoveRange(carLogs);

        var carInsurances = await RepositoryDbContext.Set<CarInsurance>()
            .Where(ci => ci.CarId == carId)
            .ToListAsync();
        RepositoryDbContext.Set<CarInsurance>().RemoveRange(carInsurances);

        // Delete the car itself
        RepositoryDbContext.Set<Car>().Remove(domainEntity);
    }
}