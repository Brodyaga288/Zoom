using Zoom.Domain.Models;
using Zoom.Domain.Models.DTO;

namespace Zoom.DAO.Repository.Intarface;

public interface IUserRepository
{
    bool IsUniqueUser(string username);
    Task<UserLoginResponseDTO> Login(UserLoginRequestDTO login);
    Task<User> Register(UserRegistrationRequestDTO register);
}