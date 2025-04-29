using App.BLL.Contracts;
using App.DAL.Contracts;
using Base.BLL;
using Base.BLL.Contracts;

namespace App.BLL.Services;

public class CarLogService : BaseService<App.BLL.DTO.CarLog, App.DAL.DTO.CarLog, App.DAL.Contracts.ICarLogRepository>, ICarLogService
{
    public CarLogService(
        IAppUOW serviceUOW, 
        IBLLMapper<App.BLL.DTO.CarLog, App.DAL.DTO.CarLog> bllMapper) : base(serviceUOW, serviceUOW.CarLogRepository, bllMapper)
    {
    }
}