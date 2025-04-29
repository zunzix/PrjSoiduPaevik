using System.ComponentModel.DataAnnotations;

namespace App.DTO.Identity;

public class RegisterInfo
{
    [MaxLength(128)]
    public string Email { get; set; } = null!;
    
    [MaxLength(128)]
    public string Password { get; set; } = null!;
}