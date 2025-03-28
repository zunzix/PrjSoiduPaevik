using System.ComponentModel.DataAnnotations;
using Base.Domain;

namespace App.Domain;

public class Group : BaseEntity
{
    [MaxLength(64)]
    public string Name { get; set; } = null!;
    
    public ICollection<GroupMember>? GroupMembers { get; set; }
    public ICollection<Car>? Cars { get; set; }
}