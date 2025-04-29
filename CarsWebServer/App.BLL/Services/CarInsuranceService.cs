using App.BLL.Contracts;
using App.DAL.Contracts;
using Base.BLL;
using Base.BLL.Contracts;

namespace App.BLL.Services;

public class CarInsuranceService : BaseService<App.BLL.DTO.CarInsurance, App.DAL.DTO.CarInsurance, App.DAL.Contracts.ICarInsuranceRepository>, ICarInsuranceService
{
    public CarInsuranceService(
        IAppUOW serviceUOW, 
        IBLLMapper<App.BLL.DTO.CarInsurance, App.DAL.DTO.CarInsurance> bllMapper) : base(serviceUOW, serviceUOW.CarInsuranceRepository, bllMapper)
    {
    }
}