using App.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Data;

public class AppDbContext : IdentityDbContext
{
    public DbSet<Person> People { get; set; } = null!;
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