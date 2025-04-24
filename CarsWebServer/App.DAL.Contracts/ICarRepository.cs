using App.Domain;
using Base.DAL.Contracts;

namespace App.DAL.Contracts;

public interface ICarRepository : IBaseRepository<Car>
{
    Task<IEnumerable<Car>> AllCarsAsync(IEnumerable<Group> userGroups);
    IEnumerable<Car> AllCars(IEnumerable<Group> userGroups);

    Task<IEnumerable<Car>> AllGroupCarsAsync(IEnumerable<Car> userCars, Guid groupId);
}