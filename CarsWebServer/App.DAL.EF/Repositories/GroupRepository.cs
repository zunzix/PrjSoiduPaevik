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
    
    public void RemoveGroupWithDependencies(App.DAL.DTO.Group entity)
    {
        var domainEntity = Mapper.Map(entity)!;
        var groupId = domainEntity.Id;

        // Delete car-related entities
        var carIds = RepositoryDbContext.Set<Car>()
            .Where(c => c.GroupId == groupId)
            .Select(c => c.Id)
            .ToList();

        RepositoryDbContext.Set<CarIssue>()
            .RemoveRange(RepositoryDbContext.Set<CarIssue>()
                .Where(ci => carIds.Contains(ci.CarId)));

        RepositoryDbContext.Set<CarLog>()
            .RemoveRange(RepositoryDbContext.Set<CarLog>()
                .Where(cl => carIds.Contains(cl.CarId)));

        RepositoryDbContext.Set<CarInsurance>()
            .RemoveRange(RepositoryDbContext.Set<CarInsurance>()
                .Where(ci => carIds.Contains(ci.CarId)));

        // Delete cars
        RepositoryDbContext.Set<Car>()
            .RemoveRange(RepositoryDbContext.Set<Car>()
                .Where(c => c.GroupId == groupId));

        // Delete group members
        RepositoryDbContext.Set<GroupMember>()
            .RemoveRange(RepositoryDbContext.Set<GroupMember>()
                .Where(gm => gm.GroupId == groupId));

        // Finally delete the group
        base.Remove(entity);
    }
    
    public async Task RemoveGroupWithDependenciesAsync(App.DAL.DTO.Group entity)
    {
        var domainEntity = Mapper.Map(entity)!;
        var groupId = domainEntity.Id;

        // Get car IDs asynchronously
        var carIds = await RepositoryDbContext.Set<Car>()
            .Where(c => c.GroupId == groupId)
            .Select(c => c.Id)
            .ToListAsync();

        // Delete car-related entities asynchronously
        var carIssues = await RepositoryDbContext.Set<CarIssue>()
            .Where(ci => carIds.Contains(ci.CarId))
            .ToListAsync();
        RepositoryDbContext.Set<CarIssue>().RemoveRange(carIssues);

        var carLogs = await RepositoryDbContext.Set<CarLog>()
            .Where(cl => carIds.Contains(cl.CarId))
            .ToListAsync();
        RepositoryDbContext.Set<CarLog>().RemoveRange(carLogs);

        var carInsurances = await RepositoryDbContext.Set<CarInsurance>()
            .Where(ci => carIds.Contains(ci.CarId))
            .ToListAsync();
        RepositoryDbContext.Set<CarInsurance>().RemoveRange(carInsurances);

        // Delete cars asynchronously
        var cars = await RepositoryDbContext.Set<Car>()
            .Where(c => c.GroupId == groupId)
            .ToListAsync();
        RepositoryDbContext.Set<Car>().RemoveRange(cars);

        // Delete group members asynchronously
        var groupMembers = await RepositoryDbContext.Set<GroupMember>()
            .Where(gm => gm.GroupId == groupId)
            .ToListAsync();
        RepositoryDbContext.Set<GroupMember>().RemoveRange(groupMembers);

        // Finally delete the group using base async method if available
        // If your base repository doesn't have RemoveAsync, you'll need to implement it
        await base.RemoveAsync(entity.Id);
    }
}