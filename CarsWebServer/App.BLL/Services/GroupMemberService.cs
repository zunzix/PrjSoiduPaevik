using App.BLL.Contracts;
using App.DAL.Contracts;
using Base.BLL;
using Base.BLL.Contracts;

namespace App.BLL.Services;

public class GroupMemberService : BaseService<App.BLL.DTO.GroupMember, App.DAL.DTO.GroupMember, App.DAL.Contracts.IGroupMemberRepository>,
    IGroupMemberService
{
    public GroupMemberService(
        IAppUOW serviceUOW,
        IBLLMapper<App.BLL.DTO.GroupMember, App.DAL.DTO.GroupMember> bllMapper) : base(serviceUOW, serviceUOW.GroupMemberRepository, bllMapper)
    {
    }
}