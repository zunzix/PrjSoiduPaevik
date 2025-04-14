using App.Domain;
using Base.DAL.Contracts;

namespace App.DAL.Contracts;

public interface ICarInsuranceRepository : IBaseRepository<CarInsurance>
{
    Task<IEnumerable<CarInsurance>> AllCarInsurancesAsync(IEnumerable<Car> userCars);
}