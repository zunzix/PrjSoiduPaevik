using App.DAL.DTO;
using Base.BLL.Contracts;

namespace App.BLL.Mappers;

public class GroupBLLMapper : IBLLMapper<App.BLL.DTO.Group, App.DAL.DTO.Group>
{
    public Group? Map(DTO.Group? entity)
    {
        throw new NotImplementedException();
    }

    public DTO.Group? Map(Group? entity)
    {
        throw new NotImplementedException();
    }
}