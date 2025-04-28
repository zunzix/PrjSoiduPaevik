using App.DAL.DTO;
using Base.DAL.Contracts;

namespace App.DAL.EF.Mappers;

public class GroupMemberMapper : IMapper<App.DAL.DTO.GroupMember, App.Domain.GroupMember>
{
    private readonly AppDbContext _context;

    public GroupMemberMapper(AppDbContext context)
    {
        _context = context;
    }


    public GroupMember? Map(Domain.GroupMember? entity)
    {
        if (entity == null) return null;
        
        var user = _context.Users.FirstOrDefault(u => u.Id == entity.UserId);
        if (user == null)
        {
            return null;
        }
        
        var res = new GroupMember()
        {
            Id = entity.Id,
                
            GroupId = entity.GroupId,
            //todo : add mapping
            Group = null,
                
            Email = user.Email!,
                
            IsAdmin = entity.IsAdmin
        };
        return res;
    }

    public Domain.GroupMember? Map(GroupMember? entity)
    {
        if (entity == null) return null;
        
        var normalizedEmail =  entity.Email.Normalize().ToUpperInvariant();
        
        var user = _context.Users.FirstOrDefault(u => u.NormalizedEmail == normalizedEmail);
        if (user == null)
        {
            return null;
        }
        
        var res = new Domain.GroupMember()
        {
            Id = entity.Id,
                
            GroupId = entity.GroupId,
            //todo : add mapping
            Group = null,
            
            UserId = user.Id,
            //todo : add mapping
            User = null,
            
                
            IsAdmin = entity.IsAdmin
        };
        return res;
    }
}