namespace Zoom.Domain.Models.DTO;

public class UserLoginResponseDTO
{
    public User User { get; set; }
    public string Token { get; set; }
}