using App.Domain;
using Base.DAL.Contracts;

namespace App.DAL.Contracts;

public interface ICarRepository : IRepository<Car>
{
    Task<IEnumerable<Car>> AllCars(IEnumerable<Group> userGroups, Guid userId = default);
}