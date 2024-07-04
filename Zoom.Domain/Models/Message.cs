using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zoom.Domain.Models;

public class Message : BaseModels
{
    public Guid MeetingId { get; set; }
    [ForeignKey("Meeting")]
    [Required]
    public Meeting Meeting { get; set; }
    public Guid UserId { get; set; }
    [ForeignKey("User")]
    [Required]
    public User User { get; set; }
    public string Content { get; set; } = String.Empty;
    public DateTime TimeStamp { get; set; }
}