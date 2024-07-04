using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zoom.Domain.Models;

public class Participant : BaseModels
{
    public Guid MeetingId { get; set; }
    [ForeignKey("Meeting")]
    [Required]
    public Meeting Meeting { get; set; }
    public Guid UserId { get; set; }
    [ForeignKey("User")]
    [Required]
    public User User { get; set; }
    
}