using Base.DAL.Contracts;

namespace App.DAL.Contracts;

public interface IAppUOW : IBaseUOW
{
    IGroupRepository GroupRepository { get; }
    IGroupMemberRepository GroupMemberRepository { get; }
    ICarRepository CarRepository { get; }
    ICarLogRepository CarLogRepository { get; }
    ICarIssueRepository CarIssueRepository { get; }
    ICarInsuranceRepository CarInsuranceRepository { get; }
}