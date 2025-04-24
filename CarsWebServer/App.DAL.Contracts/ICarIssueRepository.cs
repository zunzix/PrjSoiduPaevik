using App.Domain;
using Base.DAL.Contracts;

namespace App.DAL.Contracts;

public interface ICarIssueRepository : IBaseRepository<CarIssue>
{
    Task<IEnumerable<CarIssue>> AllCarIssuesAsync(IEnumerable<Car> userCars);
    
    Task<IEnumerable<CarIssue>> AllCarCarIssuesAsync(IEnumerable<CarIssue> userCarIssues, Guid carId);
}