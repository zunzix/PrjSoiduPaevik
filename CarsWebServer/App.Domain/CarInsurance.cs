using System.ComponentModel.DataAnnotations;
using Base.Domain;

namespace App.Domain;

public class CarInsurance : BaseEntity
{
    public Guid CarId { get; set; }
    public Car? Car { get; set; }
    
    [MaxLength(64)]
    public string Name { get; set; } = null!;
    
    public DateTime EndDate { get; set; }
}