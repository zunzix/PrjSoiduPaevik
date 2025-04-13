using System.ComponentModel.DataAnnotations;
using App.Domain.Identity;
using Base.Contracts;
using Base.Domain;

namespace App.Domain;

public class GroupMember : BaseEntity, IDomainUser<Guid, AppUser>
{
    [Display(Name = nameof(Group), Prompt = nameof(Group), ResourceType = typeof(App.Resources.Domain.GroupMember))]
    public Guid GroupId { get; set; }
    [Display(Name = nameof(Group), Prompt = nameof(Group), ResourceType = typeof(App.Resources.Domain.GroupMember))]
    public Group? Group { get; set; }
    
    
    [Display(Name = nameof(AppUser), Prompt = nameof(AppUser), ResourceType = typeof(App.Resources.Domain.GroupMember))]
    public Guid UserId { get; set; }
    //public Guid AppUserId { get; set; }
    
    [Display(Name = nameof(AppUser), Prompt = nameof(AppUser), ResourceType = typeof(App.Resources.Domain.GroupMember))]
    public AppUser? User { get; set; }
    //public AppUser? AppUser { get; set; }
    
    
    [Display(Name = nameof(IsAdmin), Prompt = nameof(IsAdmin), ResourceType = typeof(App.Resources.Domain.GroupMember))]
    public bool IsAdmin { get; set; }
}