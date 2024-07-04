using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zoom.Domain.Models;

public class Recording : BaseModels
{
    public Guid MeetingId { get; set; }
    [ForeignKey("Meeting")]
    [Required]
    public Meeting Meeting { get; set; }
    public string URL { get; set; } = string.Empty;
    public DateTime Duration { get; set; }
}