namespace App.DTO.Identity;

public class TokenRefreshInfo
{
    public string Jwt { get; set; } = null!;
    public string RefreshToken { get; set; } = null!;
}