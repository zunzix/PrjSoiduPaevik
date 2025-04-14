using App.Domain;
using Base.DAL.Contracts;

namespace App.DAL.Contracts;

public interface ICarInsuranceRepository : IRepository<CarInsurance>
{
    Task<IEnumerable<CarInsurance>> AllCarInsurancesAsync(IEnumerable<Car> userCars);
}