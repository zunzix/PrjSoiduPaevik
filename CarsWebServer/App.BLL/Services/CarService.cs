using App.BLL.Contracts;
using App.DAL.Contracts;
using Base.BLL;
using Base.BLL.Contracts;

namespace App.BLL.Services;

public class CarService : BaseService<App.BLL.DTO.Car, App.DAL.DTO.Car, App.DAL.Contracts.ICarRepository>, ICarService
{
    public CarService(
        IAppUOW serviceUOW, 
        IBLLMapper<App.BLL.DTO.Car, App.DAL.DTO.Car, Guid> bllMapper) : base(serviceUOW, serviceUOW.CarRepository, bllMapper)
    {
    }
}