using System.ComponentModel.DataAnnotations;
using App.Domain.Identity;
using Base.Domain;

namespace App.Domain;

public class CarLog : BaseEntityUser<AppUser, AppRole>
{
    [Display(Name = nameof(Car), Prompt = nameof(Car), ResourceType = typeof(App.Resources.Domain.CarLog))]
    public Guid CarId { get; set; }
    [Display(Name = nameof(Car), Prompt = nameof(Car), ResourceType = typeof(App.Resources.Domain.CarLog))]
    public Car? Car { get; set; }
    
    
    [Display(Name = nameof(StartDate), Prompt = nameof(StartDate), ResourceType = typeof(App.Resources.Domain.CarLog))]
    public DateTime StartDate { get; set; }
    
    
    [Display(Name = nameof(EndDate), Prompt = nameof(EndDate), ResourceType = typeof(App.Resources.Domain.CarLog))]
    public DateTime EndDate { get; set; }
    
    
    
    [MaxLength(64)]
    [Display(Name = nameof(StartPoint), Prompt = nameof(StartPoint), ResourceType = typeof(App.Resources.Domain.CarLog))]
    public string StartPoint { get; set; } = null!;
    
    
    
    [MaxLength(64)]
    [Display(Name = nameof(EndPoint), Prompt = nameof(EndPoint), ResourceType = typeof(App.Resources.Domain.CarLog))]
    public string EndPoint { get; set; } = null!;
    
    
    [Display(Name = nameof(Distance), Prompt = nameof(Distance), ResourceType = typeof(App.Resources.Domain.CarLog))]
    public float Distance { get; set; }

    
    
    [MaxLength(320)]
    [Display(Name = nameof(Comment), Prompt = nameof(Comment), ResourceType = typeof(App.Resources.Domain.CarLog))]
    public string? Comment { get; set; }
}