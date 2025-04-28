using App.Domain;
using Base.DAL.Contracts;

namespace App.DAL.Contracts;

public interface ICarRepository : IBaseRepository<App.DAL.DTO.Car>
{
    Task<IEnumerable<App.DAL.DTO.Car>> AllCarsAsync(IEnumerable<App.DAL.DTO.Group> userGroups);
    IEnumerable<App.DAL.DTO.Car> AllCars(IEnumerable<App.DAL.DTO.Group> userGroups);

    Task<IEnumerable<App.DAL.DTO.Car>> AllGroupCarsAsync(IEnumerable<App.DAL.DTO.Car> userCars, Guid groupId);
}