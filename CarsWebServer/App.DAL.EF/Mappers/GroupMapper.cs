using App.DAL.DTO;
using Base.DAL.Contracts;

namespace App.DAL.EF.Mappers;

public class GroupMapper : IMapper<App.DAL.DTO.Group, App.Domain.Group>
{
    public Group? Map(Domain.Group? entity)
    {
        throw new NotImplementedException();
    }

    public Domain.Group? Map(Group? entity)
    {
        throw new NotImplementedException();
    }
}