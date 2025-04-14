using App.Domain;
using Base.DAL.Contracts;

namespace App.DAL.Contracts;

public interface ICarIssueRepository : IRepository<CarIssue>
{
    Task<IEnumerable<CarIssue>> AllCarIssuesAsync(IEnumerable<Car> userCars);
}