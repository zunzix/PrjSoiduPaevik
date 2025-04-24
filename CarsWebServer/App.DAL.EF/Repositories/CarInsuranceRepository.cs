using App.DAL.Contracts;
using App.Domain;
using Base.DAL.EF;
using Microsoft.EntityFrameworkCore;

namespace App.DAL.EF.Repositories;


public class CarInsuranceRepository : BaseRepository<CarInsurance>, ICarInsuranceRepository
{
    public CarInsuranceRepository(AppDbContext repositoryDbContext) : base(repositoryDbContext)
    {
    }

    public async Task<IEnumerable<CarInsurance>> AllCarInsurancesAsync(IEnumerable<Car> userCars)
    {
        var carIds = userCars.Select(g => g.Id).ToList();
        return await RepositoryDbSet
            .Include(c => c.Car)
            .Where(c => carIds.Contains(c.CarId))
            .ToListAsync();
    }
    
    public async Task<IEnumerable<CarInsurance>> AllCarCarInsurancesAsync(IEnumerable<CarInsurance> userCarInsurances, Guid carId) 
    {
        return await Task.FromResult(userCarInsurances.Where(c => c.CarId == carId));
    }
    
    public override async Task<CarInsurance?> FindAsync(Guid id, Guid userId = default)
    {
        return await RepositoryDbSet
            .Include(c => c.Car)
            .FirstOrDefaultAsync(m => m.Id == id);
    }
}