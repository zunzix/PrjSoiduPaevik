using App.BLL.Contracts;
using App.DAL.Contracts;
using Base.BLL;
using Base.BLL.Contracts;

namespace App.BLL.Services;

public class CarIssueService : BaseService<App.BLL.DTO.CarIssue, App.DAL.DTO.CarIssue, App.DAL.Contracts.ICarIssueRepository>, ICarIssueService
{
    public CarIssueService(
        IAppUOW serviceUOW, 
        IBLLMapper<App.BLL.DTO.CarIssue, App.DAL.DTO.CarIssue> bllMapper) : base(serviceUOW, serviceUOW.CarIssueRepository, bllMapper)
    {
    }
}