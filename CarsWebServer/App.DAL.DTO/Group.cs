using System.ComponentModel.DataAnnotations;
using App.Resources.Domain;
using Base.Contracts;

namespace App.DAL.DTO;

public class Group : IDomainId
{
    public Guid Id { get; set; }
    
    [MaxLength(64)]
    [Display(Name = nameof(Name), Prompt = nameof(Name), ResourceType = typeof(App.Resources.Domain.Group))]
    public string Name { get; set; } = null!;
    
    public ICollection<GroupMember>? GroupMembers { get; set; }
    public ICollection<Car>? Cars { get; set; }
}