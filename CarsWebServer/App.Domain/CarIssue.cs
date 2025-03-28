using System.ComponentModel.DataAnnotations;
using Base.Domain;

namespace App.Domain;

public class CarIssue : BaseEntity
{
    public Guid CarId { get; set; }
    public Car? Car { get; set; }
    
    [MaxLength(320)]
    public string Issue { get; set; } = null!;
    
    public bool IsCritical { get; set; }
    
    public bool IsResolved { get; set; }
}