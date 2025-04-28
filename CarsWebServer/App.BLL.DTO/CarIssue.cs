using System.ComponentModel.DataAnnotations;
using Base.Contracts;

namespace App.BLL.DTO;

public class CarIssue : IDomainId
{
    public Guid Id { get; set; }
    
    [Display(Name = nameof(Car), Prompt = nameof(Car), ResourceType = typeof(App.Resources.Domain.CarIssue))]
    public Guid CarId { get; set; }
    [Display(Name = nameof(Car), Prompt = nameof(Car), ResourceType = typeof(App.Resources.Domain.CarIssue))]
    public Car? Car { get; set; }
    
    
    [MaxLength(320)]
    [Display(Name = nameof(Issue), Prompt = nameof(Issue), ResourceType = typeof(App.Resources.Domain.CarIssue))]
    public string Issue { get; set; } = null!;
    
    
    [Display(Name = nameof(IsCritical), Prompt = nameof(IsCritical), ResourceType = typeof(App.Resources.Domain.CarIssue))]
    public bool IsCritical { get; set; }
    
    
    [Display(Name = nameof(IsResolved), Prompt = nameof(IsResolved), ResourceType = typeof(App.Resources.Domain.CarIssue))]
    public bool IsResolved { get; set; }
}