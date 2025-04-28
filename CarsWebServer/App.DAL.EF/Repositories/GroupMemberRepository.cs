using App.DAL.Contracts;
using App.DAL.EF.Mappers;
using App.Domain;
using Base.DAL.EF;
using Microsoft.EntityFrameworkCore;

namespace App.DAL.EF.Repositories;

public class GroupMemberRepository : BaseRepository<App.DAL.DTO.GroupMember, App.Domain.GroupMember>, IGroupMemberRepository
{
    public GroupMemberRepository(AppDbContext repositoryDbContext) : base(repositoryDbContext, new GroupMemberMapper(repositoryDbContext))
    {
    }
    
    public override async Task<IEnumerable<App.DAL.DTO.GroupMember>> AllAsync(Guid userId = default)
    {
        var userGroups = await RepositoryDbSet
            .Where(gm => gm.UserId == userId)
            .Select(gm => gm.GroupId)
            .ToListAsync();
        
        return (await RepositoryDbSet
            .Include(g => g.User)
            .Include(g => g.Group)
            .Where(gm => userGroups.Contains(gm.GroupId))
            .ToListAsync()).Select(e => Mapper.Map(e)!);
            
    }
    
    public async Task<IEnumerable<App.DAL.DTO.GroupMember>> AllGroupGroupMembersAsync(IEnumerable<App.DAL.DTO.GroupMember> userGroupMembers, Guid groupId) 
    {
        return await Task.FromResult(userGroupMembers.Where(c => c.GroupId == groupId));
    }
    
    public override async Task<App.DAL.DTO.GroupMember?> FindAsync(Guid id, Guid userId = default)
    {
        var res = await RepositoryDbSet
            .Include(g => g.User)
            .Include(g => g.Group)
            .Where(gm => gm.Id == id && gm.UserId == userId)
            .FirstOrDefaultAsync();
        return Mapper.Map(res);
    }
    
}