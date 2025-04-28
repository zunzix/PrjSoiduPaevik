using App.Domain;
using Base.DAL.Contracts;

namespace App.DAL.Contracts;

public interface ICarInsuranceRepository : IBaseRepository<App.DAL.DTO.CarInsurance>
{
    Task<IEnumerable<App.DAL.DTO.CarInsurance>> AllCarInsurancesAsync(IEnumerable<App.DAL.DTO.Car> userCars);
    
    Task<IEnumerable<App.DAL.DTO.CarInsurance>> AllCarCarInsurancesAsync(IEnumerable<App.DAL.DTO.CarInsurance> userCarInsurances, Guid carId);
}