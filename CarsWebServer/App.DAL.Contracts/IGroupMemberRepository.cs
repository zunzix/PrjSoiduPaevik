using App.Domain;
using Base.DAL.Contracts;

namespace App.DAL.Contracts;

public interface IGroupMemberRepository : IBaseRepository<App.DAL.DTO.GroupMember>
{
    Task<IEnumerable<App.DAL.DTO.GroupMember>> AllGroupGroupMembersAsync(IEnumerable<App.DAL.DTO.GroupMember> userGroupMembers, Guid groupId);
}