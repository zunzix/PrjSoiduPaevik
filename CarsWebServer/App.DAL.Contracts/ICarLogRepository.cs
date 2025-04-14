using App.Domain;
using Base.DAL.Contracts;

namespace App.DAL.Contracts;

public interface ICarLogRepository : IRepository<CarLog>
{
    Task<IEnumerable<CarLog>> AllCarLogsAsync(IEnumerable<Car> userCars);
}