using System.ComponentModel.DataAnnotations;
using Base.Domain;

namespace App.Domain;

public class Car : BaseEntity
{
    public Guid GroupId { get; set; }
    public Group? Group { get; set; }
    
    [MaxLength(64)]
    public string Name { get; set; } = null!;
    
    public float Mileage { get; set; }
    
    public float AvgFuelCons { get; set; }
    
    public bool IsAvailable { get; set; }
    
    public bool IsArchived { get; set; }
    
    public ICollection<CarIssue>? CarIssues { get; set; }
    public ICollection<CarInsurance>? CarInsurances { get; set; }
    public ICollection<CarLog>? CarLogs { get; set; }
}