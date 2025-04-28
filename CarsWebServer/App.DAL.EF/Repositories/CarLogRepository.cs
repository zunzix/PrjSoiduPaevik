using App.DAL.Contracts;
using App.DAL.EF.Mappers;
using App.Domain;
using Base.DAL.EF;
using Microsoft.EntityFrameworkCore;

namespace App.DAL.EF.Repositories;

public class CarLogRepository : BaseRepository<App.DAL.DTO.CarLog, App.Domain.CarLog>, ICarLogRepository
{
    public CarLogRepository(AppDbContext repositoryDbContext) : base(repositoryDbContext, new CarLogMapper(repositoryDbContext))
    {
    }

    public async Task<IEnumerable<App.DAL.DTO.CarLog>> AllCarLogsAsync(
        IEnumerable<App.DAL.DTO.Car> userCars)
    {
        var carIds = userCars.Select(g => g.Id).ToList();
        return (await RepositoryDbSet
            .Include(c => c.Car)
            .Include(c => c.User)
            .Where(c => carIds.Contains(c.CarId))
            .ToListAsync()).Select(e => Mapper.Map(e)!);
    }
    
    public async Task<IEnumerable<App.DAL.DTO.CarLog>> AllCarCarLogsAsync(IEnumerable<App.DAL.DTO.CarLog> userCarLogs, Guid carId) 
    {
        return await Task.FromResult(userCarLogs.Where(c => c.CarId == carId));
    }
    
    public override async Task<App.DAL.DTO.CarLog?> FindAsync(Guid id, Guid userId = default)
    {
        var res = await RepositoryDbSet
            .Include(c => c.User)
            .Include(c => c.Car)
            .Where(g => g.Car!.Group!.GroupMembers!.Any(gm => gm.UserId == userId))
            .FirstOrDefaultAsync(m => m.Id == id);
        return Mapper.Map(res);
    }
}