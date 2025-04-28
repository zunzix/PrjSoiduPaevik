using App.DAL.DTO;
using Base.DAL.Contracts;

namespace App.DAL.EF.Mappers;

public class GroupMemberMapper : IMapper<App.DAL.DTO.GroupMember, App.Domain.GroupMember>
{
    public GroupMember? Map(Domain.GroupMember? entity)
    {
        throw new NotImplementedException();
    }

    public Domain.GroupMember? Map(GroupMember? entity)
    {
        throw new NotImplementedException();
    }
}