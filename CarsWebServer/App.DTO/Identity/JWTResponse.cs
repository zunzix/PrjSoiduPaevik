namespace App.DTO.Identity;

public class JWTResponse
{
    public string JWT { get; set; } = null!;
    public string RefreshToken { get; set; } = null!;
}