using App.Domain;
using Base.DAL.Contracts;

namespace App.DAL.Contracts;

public interface ICarIssueRepository : IBaseRepository<App.DAL.DTO.CarIssue>
{
    Task<IEnumerable<App.DAL.DTO.CarIssue>> AllCarIssuesAsync(IEnumerable<App.DAL.DTO.Car> userCars);
    
    Task<IEnumerable<App.DAL.DTO.CarIssue>> AllCarCarIssuesAsync(IEnumerable<App.DAL.DTO.CarIssue> userCarIssues, Guid carId);
}