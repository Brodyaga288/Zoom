using Zoom.Domain.Primitives;
using Zoom.Domain.ValueObject;

namespace Zoom.Domain.Models.DTO;

public class UserRegistrationRequestDTO
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public FullName Name { get; set; }
    public string Password { get; set; }
    public Role Role { get; set; }
}