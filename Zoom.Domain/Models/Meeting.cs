using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Zoom.Domain.Primitives;

namespace Zoom.Domain.Models;

public class Meeting : BaseModels
{
    public Guid UserId { get; set; }
    [ForeignKey("User")]
    [Required]
    public User User { get; set; }
    public string MeetingName { get; set; } = string.Empty;
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public Status Status { get; set; }
    public Participant Participant { get; set; }
    public Chat Chat { get; set; }
    public Message Message { get; set; }
    public Recording Recording { get; set; }
}