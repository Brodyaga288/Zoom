using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Zoom.DAO.Repository.Intarface;
using Zoom.Domain.Models;
using Zoom.Domain.Models.DTO;

namespace Zoom.DAO.Repository.Inplementation;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    private readonly ApplicationContext _db;
    private string? secretKey;
    public UserRepository(ApplicationContext db, IConfiguration config) : base(db)
    {
        _db = db;
        secretKey = config.GetSection("ApiSettings:Secret").Value;
    }

    public bool IsUniqueUser(string username)
    {
        var user = _db.Users.FirstOrDefault(x => x.UserName == username);
        if (user == null)
        {
            return true;
        }

        return false;
    }

    public async Task<UserLoginResponseDTO> Login(UserLoginRequestDTO login)
    {
        var user = _db.Users.FirstOrDefault(u => u.UserName == login.UserName
                                                 && u.Password == login.Password);
        if (user == null)
        {
            return new UserLoginResponseDTO()
            {
                Token = "",
                User = null
            };
        }

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(secretKey);
        var tokenDescriptor = new SecurityTokenDescriptor()
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name, user.Id.ToString()),
                new Claim(ClaimTypes.Role, user.Role.ToString())
            }),
            Expires = DateTime.UtcNow.AddDays(1),
            SigningCredentials = new(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        UserLoginResponseDTO loginUser = new UserLoginResponseDTO()
        {
            Token = tokenHandler.WriteToken(token),
            User = user
        };
        return loginUser;
    }

    public async Task<User> Register(UserRegistrationRequestDTO register)
    {
        User user = new User()
        {
            UserName = register.UserName,
            Email = register.Email,
            Password = register.Password,
            FullName = register.Name,
            Role = register.Role
        };
        _db.Users.Add(user);
        await _db.SaveChangesAsync();
        user.Password = "";
        return user;
    }
}