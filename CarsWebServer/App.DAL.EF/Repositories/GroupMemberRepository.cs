using App.DAL.Contracts;
using App.Domain;
using Base.DAL.EF;
using Microsoft.EntityFrameworkCore;

namespace App.DAL.EF.Repositories;

public class GroupMemberRepository : BaseRepository<GroupMember>, IGroupMemberRepository
{
    public GroupMemberRepository(DbContext repositoryDbContext) : base(repositoryDbContext)
    {
    }
    
    public override async Task<IEnumerable<GroupMember>> AllAsync(Guid userId = default)
    {
        var userGroups = await RepositoryDbSet
            .Where(gm => gm.UserId == userId)
            .Select(gm => gm.GroupId)
            .ToListAsync();
        
        return await RepositoryDbSet
            .Include(g => g.User)
            .Include(g => g.Group)
            .Where(gm => userGroups.Contains(gm.GroupId))
            .ToListAsync();
            
    }
    
    public override async Task<GroupMember?> FindAsync(Guid id, Guid userId = default)
    {
        return await RepositoryDbSet
            .Include(g => g.User)
            .Include(g => g.Group)
            .Where(gm => gm.Id == id && gm.UserId == userId)
            .FirstOrDefaultAsync();
    }
    
}