using System.ComponentModel.DataAnnotations;
using Base.Domain;

namespace App.Domain;

public class CarInsurance : BaseEntity
{
    [Display(Name = nameof(Car), Prompt = nameof(Car), ResourceType = typeof(App.Resources.Domain.CarInsurance))]
    public Guid CarId { get; set; }
    [Display(Name = nameof(Car), Prompt = nameof(Car), ResourceType = typeof(App.Resources.Domain.CarInsurance))]
    public Car? Car { get; set; }
    
    
    [MaxLength(64)]
    [Display(Name = nameof(Name), Prompt = nameof(Name), ResourceType = typeof(App.Resources.Domain.CarInsurance))]
    public string Name { get; set; } = null!;
    
    [Display(Name = nameof(EndDate), Prompt = nameof(EndDate), ResourceType = typeof(App.Resources.Domain.CarInsurance))]
    public DateTime EndDate { get; set; }
}