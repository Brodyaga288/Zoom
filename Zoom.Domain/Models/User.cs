using System.ComponentModel.DataAnnotations;
using Zoom.Domain.Primitives;
using Zoom.Domain.ValueObject;

namespace Zoom.Domain.Models;

public class User : BaseModels
{
    [Required]
    public FullName FullName { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public Role Role { get; set; }
    [Required] 
    public string Password { get; set; }
    [Required]
    public string UserName { get; set; }
    public Meeting Meeting { get; set; }
    public Participant Participant { get; set; }
    public Chat Chat { get; set; }
    public Message Message { get; set; }
}