using App.DAL.Contracts;
using App.DAL.EF.Mappers;
using Base.DAL.EF;
using App.Domain;
using App.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace App.DAL.EF.Repositories;

public class GroupRepository : BaseRepository<App.DAL.DTO.Group, App.Domain.Group>, IGroupRepository
{
    public GroupRepository(AppDbContext repositoryDbContext) : base(repositoryDbContext, new GroupMapper(repositoryDbContext))
    {
    }
    
    public override async Task<IEnumerable<App.DAL.DTO.Group>> AllAsync(Guid userId = default)
    {
        return (await RepositoryDbSet
            .Where(g => g.GroupMembers!.Any(gm => gm.UserId == userId))
            .ToListAsync()).Select(e => Mapper.Map(e)!);
    }
    
    public override IEnumerable<App.DAL.DTO.Group> All(Guid userId = default)
    {
        return RepositoryDbSet
            .Where(g => g.GroupMembers!.Any(gm => gm.UserId == userId))
            .ToList().Select(e => Mapper.Map(e)!);
    }
    
    public override async Task<App.DAL.DTO.Group?> FindAsync(Guid id, Guid userId = default)
    {
        var res = await RepositoryDbSet
            .Where(g => g.Id == id)
            .Where(g => g.GroupMembers!.Any(gm => gm.UserId == userId))
            .FirstOrDefaultAsync();
        return Mapper.Map(res);
    }

    public IEnumerable<App.DAL.DTO.Group> AllAdmins(Guid userId)
    {
        return RepositoryDbSet
            .Where(g => g.GroupMembers!
                .Any(gm => gm.UserId == userId && gm.IsAdmin))
            .ToList().Select(e => Mapper.Map(e)!);
    }

    public async Task<IEnumerable<App.DAL.DTO.Group>> AllAdminsAsync(Guid userId)
    {
        return (await RepositoryDbSet
            .Where(g => g.GroupMembers!
                .Any(gm => gm.UserId == userId && gm.IsAdmin))
            .ToListAsync()).Select(e => Mapper.Map(e)!);
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