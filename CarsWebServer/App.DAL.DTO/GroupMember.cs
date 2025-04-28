using System.ComponentModel.DataAnnotations;
using Base.Contracts;

namespace App.DAL.DTO;

public class GroupMember : IDomainId
{
    public Guid Id { get; set; }
    
    [Display(Name = nameof(Group), Prompt = nameof(Group), ResourceType = typeof(App.Resources.Domain.GroupMember))]
    public Guid GroupId { get; set; }
    [Display(Name = nameof(Group), Prompt = nameof(Group), ResourceType = typeof(App.Resources.Domain.GroupMember))]
    public Group? Group { get; set; }
    
    [MaxLength(256)]
    [Display(Name = nameof(Email), Prompt = nameof(Email), ResourceType = typeof(Base.Resources.Common))]
    public string Email { get; set; } = null!;
    
    [Display(Name = nameof(IsAdmin), Prompt = nameof(IsAdmin), ResourceType = typeof(App.Resources.Domain.GroupMember))]
    public bool IsAdmin { get; set; }
}