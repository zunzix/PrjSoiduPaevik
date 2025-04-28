using Base.BLL.Contracts;

namespace App.BLL.Contracts;

public interface IAppBLL : IBaseBLL
{
    IGroupService GroupService { get; }
    IGroupMemberService GroupMemberService { get; }
    ICarService CarService { get; }
    ICarInsuranceService CarInsuranceService { get; }
    ICarIssueService CarIssueService { get; }
    ICarLogService CarLogService { get; }
}