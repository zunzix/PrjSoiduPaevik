using System.ComponentModel.DataAnnotations;
using App.Domain.Identity;
using Base.Domain;

namespace App.Domain;

public class GroupMember : BaseEntityUser<AppUser>
{
    [Display(Name = nameof(Group), Prompt = nameof(Group), ResourceType = typeof(App.Resources.Domain.GroupMember))]
    public Guid GroupId { get; set; }
    [Display(Name = nameof(Group), Prompt = nameof(Group), ResourceType = typeof(App.Resources.Domain.GroupMember))]
    public Group? Group { get; set; }
    
    [Display(Name = nameof(IsAdmin), Prompt = nameof(IsAdmin), ResourceType = typeof(App.Resources.Domain.GroupMember))]
    public bool IsAdmin { get; set; }
}