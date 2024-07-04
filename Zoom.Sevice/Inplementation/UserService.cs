using Zoom.DAO.Repository.Intarface;
using Zoom.Domain.Models;
using Zoom.Domain.Models.DTO;
using Zoom.Sevice.Interface;

namespace Zoom.Sevice.Inplementation;

public class UserService : BaseService<User>, IUserService
{
    private readonly IUserRepository _user;
    public UserService(IBaseRepository<User?> repository, IUserRepository user) : base(repository)
    {
        _user = user;
    }


    public bool IsUniqueUser(string username)
    {
        return _user.IsUniqueUser(username);
    }

    public Task<UserLoginResponseDTO> Login(UserLoginRequestDTO login)
    {
       return _user.Login(login);
    }

    public Task<User> Register(UserRegistrationRequestDTO register)
    {
       return _user.Register(register);
    }
}