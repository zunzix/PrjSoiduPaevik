

using App.Domain;
using Base.DAL.Contracts;

namespace App.DAL.Contracts;

public interface IGroupRepository : IRepository<Group>
{
    IEnumerable<Group> AllAdmins(Guid userId);
}