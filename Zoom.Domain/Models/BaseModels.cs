using System.ComponentModel.DataAnnotations;
using Zoom.Domain.Models.Interface;

namespace Zoom.Domain.Models;

public class BaseModels : IBaseModels
{
    [Key]
    public Guid Id { get; set; }
    public DateTime DateCreate { get; set; }
    public DateTime DateUpdate { get; set; }
}