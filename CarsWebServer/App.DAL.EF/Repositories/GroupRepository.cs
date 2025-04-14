using App.DAL.Contracts;
using Base.DAL.EF;
using App.Domain;
using Microsoft.EntityFrameworkCore;

namespace App.DAL.EF.Repositories;

public class GroupRepository : BaseRepository<Group>, IGroupRepository
{
    public GroupRepository(AppDbContext repositoryDbContext) : base(repositoryDbContext)
    {
    }
    
    public override async Task<IEnumerable<Group>> AllAsync(Guid userId = default)
    {
        return await RepositoryDbSet
            .Where(g => g.GroupMembers!.Any(gm => gm.UserId == userId))
            .ToListAsync();
    }
    
    public override IEnumerable<Group> All(Guid userId = default)
    {
        return RepositoryDbSet
            .Where(g => g.GroupMembers!.Any(gm => gm.UserId == userId))
            .ToList();
    }

    public IEnumerable<Group> AllAdmins(Guid userId)
    {
        return RepositoryDbSet
            .Where(g => g.GroupMembers!
                .Any(gm => gm.UserId == userId && gm.IsAdmin))
            .ToList();
    }

    public async Task<IEnumerable<Group>> AllAdminsAsync(Guid userId)
    {
        return await RepositoryDbSet
            .Where(g => g.GroupMembers!
                .Any(gm => gm.UserId == userId && gm.IsAdmin))
            .ToListAsync();
    }
    
    public async Task<bool> IsUserAdminInGroup(Guid userId, Guid groupId)
    {
        return await RepositoryDbSet
            .Where(g => g.Id == groupId)
            .AnyAsync(g => g.GroupMembers!
                .Any(gm => gm.UserId == userId && gm.IsAdmin));
    }

    public async Task<bool> IsUserInGroup(Guid userId, Guid groupId)
    {
        return await RepositoryDbSet
            .Where(g => g.Id == groupId)
            .AnyAsync(g => g.GroupMembers!
                .Any(gm => gm.UserId == userId));
    }
}