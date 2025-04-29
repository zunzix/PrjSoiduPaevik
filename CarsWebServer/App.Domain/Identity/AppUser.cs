using Base.Contracts;
using Base.Domain.Identity;
using Microsoft.AspNetCore.Identity;

namespace App.Domain.Identity;

public class AppUser : BaseUser<AppUserRole>, IDomainId
{
    
    public ICollection<GroupMember>? GroupMembers { get; set; }
    public ICollection<CarLog>? CarLogs { get; set; }
    public ICollection<AppRefreshToken>? RefreshTokens { get; set; }
    
}