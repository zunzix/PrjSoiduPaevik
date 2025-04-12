using Microsoft.AspNetCore.Identity;

namespace App.Domain.Identity;

public class AppUser : IdentityUser<Guid>
{
    
    public ICollection<GroupMember>? GroupMembers { get; set; }
    public ICollection<CarLog>? CarLogs { get; set; }
    
}