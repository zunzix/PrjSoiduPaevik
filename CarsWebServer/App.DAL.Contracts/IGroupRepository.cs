

using App.Domain;
using Base.DAL.Contracts;

namespace App.DAL.Contracts;

public interface IGroupRepository : IBaseRepository<App.DAL.DTO.Group>
{
    IEnumerable<App.DAL.DTO.Group> AllAdmins(Guid userId);
    
    Task<IEnumerable<App.DAL.DTO.Group>> AllAdminsAsync(Guid userId);
    
    Task<bool> IsUserAdminInGroup(Guid userId, Guid groupId);
    Task<bool> IsUserInGroup(Guid userId, Guid groupId);
}