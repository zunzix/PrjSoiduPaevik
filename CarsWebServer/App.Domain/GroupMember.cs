using System.ComponentModel.DataAnnotations;
using Base.Domain;

namespace App.Domain;

public class GroupMember : BaseEntity
{
    [Display(Name = nameof(Group), Prompt = nameof(Group), ResourceType = typeof(App.Resources.Domain.GroupMember))]
    public Guid GroupId { get; set; }
    [Display(Name = nameof(Group), Prompt = nameof(Group), ResourceType = typeof(App.Resources.Domain.GroupMember))]
    public Group? Group { get; set; }
    
    
    [Display(Name = nameof(Person), Prompt = nameof(Person), ResourceType = typeof(App.Resources.Domain.GroupMember))]
    public Guid PersonId { get; set; }
    [Display(Name = nameof(Person), Prompt = nameof(Person), ResourceType = typeof(App.Resources.Domain.GroupMember))]
    public Person? Person { get; set; }
    
    
    [Display(Name = nameof(IsAdmin), Prompt = nameof(IsAdmin), ResourceType = typeof(App.Resources.Domain.GroupMember))]
    public bool IsAdmin { get; set; }
}