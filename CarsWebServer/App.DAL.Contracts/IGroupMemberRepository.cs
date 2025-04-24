using App.Domain;
using Base.DAL.Contracts;

namespace App.DAL.Contracts;

public interface IGroupMemberRepository : IBaseRepository<GroupMember>
{
    Task<IEnumerable<GroupMember>> AllGroupGroupMembersAsync(IEnumerable<GroupMember> userGroupMembers, Guid groupId);
}