using App.DAL.DTO;
using Base.BLL.Contracts;

namespace App.BLL.Mappers;

public class GroupMemberBLLMapper : IBLLMapper<App.BLL.DTO.GroupMember, App.DAL.DTO.GroupMember>
{
    public GroupMember? Map(DTO.GroupMember? entity)
    {
        throw new NotImplementedException();
    }

    public DTO.GroupMember? Map(GroupMember? entity)
    {
        throw new NotImplementedException();
    }
}