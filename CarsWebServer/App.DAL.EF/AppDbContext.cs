using App.Domain;
using App.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace App.DAL.EF;

public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid, IdentityUserClaim<Guid>, IdentityUserRole<Guid>,
    IdentityUserLogin<Guid>, IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>

{
    public DbSet<Car> Cars { get; set; } = null!;
    public DbSet<Group> Groups { get; set; } = null!;
    public DbSet<GroupMember> GroupMembers { get; set; } = null!;
    public DbSet<CarIssue> CarIssues { get; set; } = null!;
    public DbSet<CarInsurance> CarInsurances { get; set; } = null!;
    public DbSet<CarLog> CarLogs { get; set; } = null!;
    
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    

}