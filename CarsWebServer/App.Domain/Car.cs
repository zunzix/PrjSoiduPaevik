using System.ComponentModel.DataAnnotations;
using Base.Domain;

namespace App.Domain;

public class Car : BaseEntity
{
    [Display(Name = nameof(Group), Prompt = nameof(Group), ResourceType = typeof(App.Resources.Domain.Car))]
    public Guid GroupId { get; set; }
    [Display(Name = nameof(Group), Prompt = nameof(Group), ResourceType = typeof(App.Resources.Domain.Car))]
    public Group? Group { get; set; }
    
    
    [MaxLength(64)]
    [Display(Name = nameof(Name), Prompt = nameof(Name), ResourceType = typeof(App.Resources.Domain.Car))]
    public string Name { get; set; } = null!;
    
    
    [Display(Name = nameof(Mileage), Prompt = nameof(Mileage), ResourceType = typeof(App.Resources.Domain.Car))]
    public float Mileage { get; set; }
    
    
    [Display(Name = nameof(AvgFuelCons), Prompt = nameof(AvgFuelCons), ResourceType = typeof(App.Resources.Domain.Car))]
    public float AvgFuelCons { get; set; }
    
    
    [Display(Name = nameof(IsAvailable), Prompt = nameof(IsAvailable), ResourceType = typeof(App.Resources.Domain.Car))]
    public bool IsAvailable { get; set; }
    
    
    [Display(Name = nameof(IsArchived), Prompt = nameof(IsArchived), ResourceType = typeof(App.Resources.Domain.Car))]
    public bool IsArchived { get; set; }
    
    
    public ICollection<CarIssue>? CarIssues { get; set; }
    public ICollection<CarInsurance>? CarInsurances { get; set; }
    public ICollection<CarLog>? CarLogs { get; set; }
}