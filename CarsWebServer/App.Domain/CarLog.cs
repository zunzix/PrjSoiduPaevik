using System.ComponentModel.DataAnnotations;
using Base.Domain;

namespace App.Domain;

public class CarLog : BaseEntity
{
    public Guid CarId { get; set; }
    public Car? Car { get; set; }
    
    public Guid PersonId { get; set; }
    public Person? Person { get; set; }
    
    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }
    
    [MaxLength(64)]
    public string StartPoint { get; set; } = null!;
    
    [MaxLength(64)]
    public string EndPoint { get; set; } = null!;
    
    public float Distance { get; set; }

    [MaxLength(320)]
    public string Comment { get; set; } = null!;
}