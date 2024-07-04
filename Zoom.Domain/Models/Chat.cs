using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zoom.Domain.Models;

public class Chat : BaseModels
{
    public Guid MeetingId { get; set; }
    [ForeignKey("Meeting")]
    [Required]
    public Meeting Meeting { get; set; }
    public Guid UserId { get; set; }
    [ForeignKey("User")]
    [Required]
    public User User { get; set; }
    public string Content { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; }

}