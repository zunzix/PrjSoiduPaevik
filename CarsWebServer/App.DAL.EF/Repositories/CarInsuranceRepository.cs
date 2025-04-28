using App.DAL.Contracts;
using App.DAL.EF.Mappers;
using App.Domain;
using Base.DAL.EF;
using Microsoft.EntityFrameworkCore;

namespace App.DAL.EF.Repositories;


public class CarInsuranceRepository : BaseRepository<App.DAL.DTO.CarInsurance, App.Domain.CarInsurance>, ICarInsuranceRepository
{
    public CarInsuranceRepository(AppDbContext repositoryDbContext) : base(repositoryDbContext, new CarInsuranceMapper())
    {
    }

    public async Task<IEnumerable<App.DAL.DTO.CarInsurance>> AllCarInsurancesAsync(IEnumerable<App.DAL.DTO.Car> userCars)
    {
        var carIds = userCars.Select(g => g.Id).ToList();
        return (await RepositoryDbSet
            .Include(c => c.Car)
            .Where(c => carIds.Contains(c.CarId))
            .ToListAsync()).Select(e => Mapper.Map(e)!);
    }
    
    public async Task<IEnumerable<App.DAL.DTO.CarInsurance>> AllCarCarInsurancesAsync(IEnumerable<App.DAL.DTO.CarInsurance> userCarInsurances, Guid carId) 
    {
        return await Task.FromResult(userCarInsurances.Where(c => c.CarId == carId));
    }
    
    public override async Task<App.DAL.DTO.CarInsurance?> FindAsync(Guid id, Guid userId = default)
    {
        var res = await RepositoryDbSet
            .Include(c => c.Car)
            .Where(g => g.Car!.Group!.GroupMembers!.Any(gm => gm.UserId == userId))
            .FirstOrDefaultAsync(m => m.Id == id);
        return Mapper.Map(res);
    }
}