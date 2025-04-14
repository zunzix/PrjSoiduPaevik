namespace App.DTO.Identity;

public class LogoutInfo
{
    public string RefreshToken { get; set; } = null!; // The refresh token to invalidate
}