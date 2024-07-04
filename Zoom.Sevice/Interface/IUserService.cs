using Zoom.Domain.Models;
using Zoom.Domain.Models.DTO;

namespace Zoom.Sevice.Interface;

public interface IUserService
{
    bool IsUniqueUser(string username);
    Task<UserLoginResponseDTO> Login(UserLoginRequestDTO login);
    Task<User> Register(UserRegistrationRequestDTO register);
    
}