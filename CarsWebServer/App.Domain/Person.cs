using System.ComponentModel.DataAnnotations;
using Base.Domain;

namespace App.Domain;

public class Person : BaseEntity
{
    [MaxLength(32)]
    public string Name { get; set; } = null!;
    
    public ICollection<GroupMember>? GroupMembers { get; set; }
    public ICollection<CarLog>? CarLogs { get; set; }
}