using Microsoft.AspNetCore.Mvc;
using Zoom.DAO.Repository.Intarface;
using Zoom.Domain.Models;
using Zoom.Domain.Models.DTO;
using Zoom.Sevice.Inplementation;
using Zoom.Sevice.Interface;

namespace Zoom.Application.Controllers;
[Route("api/UsersAuth")]
[ApiController]
public class UserController : Controller
{
    private IUserService _user;
    public UserController(IUserService service)
    {
        _user = service;
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] UserLoginRequestDTO model)
    {
        var loginResponse = await _user.Login(model);
        if (loginResponse.User==null || string.IsNullOrEmpty(loginResponse.Token))
        {
            return BadRequest(new { Message = "Username or password is incorrect" });
        }

        return Ok(loginResponse);
    }
    
    [HttpPost("Login")]
    public async Task<IActionResult> Register([FromBody] UserRegistrationRequestDTO model)
    {
        bool ifUserNameUnique = _user.IsUniqueUser(model.UserName);
        if (!ifUserNameUnique)
        {
            return BadRequest(new { Message = "Username already exists" });
        }

        var user = await _user.Register(model);
        if (user == null)
        {
            return BadRequest(new { Message = "Error while registering" });
        }

        return Ok(user);
    }
    // [HttpGet]
    // public IActionResult GetAll()
    // {
    //     var users = _user.GetAll();
    //     return Ok(users);
    // }
    //
    // [HttpGet]
    // public IActionResult Get(Guid id)
    // {
    //     var user = _user.Get(id);
    //     return Ok(user);
    // }
    //
    // [HttpPost]
    // public IActionResult Create(User entity)
    // {
    //    var user = _user.Create(entity);
    //    return Ok(user);
    // }
    //
    // [HttpPut]
    // public IActionResult Update(User entity)
    // {
    //     var user = _user.Update(entity);
    //     return Ok(user);
    // }
    //
    // [HttpDelete]
    // public IActionResult Delete(Guid id)
    // {
    //     var user = _user.Delete(id);
    //     return Ok(user);
    // }
}