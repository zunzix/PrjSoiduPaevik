

using App.Domain;
using Base.DAL.Contracts;

namespace App.DAL.Contracts;

public interface IGroupRepository : IBaseRepository<Group>
{
    IEnumerable<Group> AllAdmins(Guid userId);
    
    Task<IEnumerable<Group>> AllAdminsAsync(Guid userId);
}