using App.BLL.Contracts;
using App.BLL.Mappers;
using App.BLL.Services;
using App.DAL.Contracts;
using Base.BLL;

namespace App.BLL;

public class AppBLL : BaseBLL<IAppUOW>, IAppBLL
{
    public AppBLL(IAppUOW uow) : base(uow)
    {
    }

    private IGroupService? _groupService;
    public IGroupService GroupService => 
        _groupService ??= new GroupService(
            BLLUOW, 
            new GroupBLLMapper()
        );
    
    private IGroupMemberService? _groupMemberService;
    public IGroupMemberService GroupMemberService => 
        _groupMemberService ??= new GroupMemberService(
            BLLUOW, 
            new GroupMemberBLLMapper()
        );
    
    private ICarService? _carService;
    public ICarService CarService => 
        _carService ??= new CarService(
            BLLUOW, 
            new CarBLLMapper()
        );
    
    private ICarLogService? _carLogService;
    public ICarLogService CarLogService => 
        _carLogService ??= new CarLogService(
            BLLUOW, 
            new CarLogBLLMapper()
        );
    
    private ICarInsuranceService? _carInsuranceService;
    public ICarInsuranceService CarInsuranceService => 
        _carInsuranceService ??= new CarInsuranceService(
            BLLUOW, 
            new CarInsuranceBLLMapper()
        );
    
    private ICarIssueService? _carIssueService;
    public ICarIssueService CarIssueService => 
        _carIssueService ??= new CarIssueService(
            BLLUOW, 
            new CarIssueBLLMapper()
        );
}