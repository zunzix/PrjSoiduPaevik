using App.Domain;
using Base.DAL.Contracts;

namespace App.DAL.Contracts;

public interface ICarLogRepository : IBaseRepository<App.DAL.DTO.CarLog>
{
    Task<IEnumerable<App.DAL.DTO.CarLog>> AllCarLogsAsync(IEnumerable<App.DAL.DTO.Car> userCars);

    Task<IEnumerable<App.DAL.DTO.CarLog>> AllCarCarLogsAsync(IEnumerable<App.DAL.DTO.CarLog> userCarLogs, Guid carId);
}