using App.DAL.Contracts;
using Base.DAL.EF;
using App.Domain;
using Microsoft.EntityFrameworkCore;

namespace App.DAL.EF.Repositories;

public class GroupRepository : BaseRepository<Group>, IGroupRepository
{
    public GroupRepository(DbContext repositoryDbContext) : base(repositoryDbContext)
    {
    }
}