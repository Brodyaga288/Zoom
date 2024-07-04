namespace Zoom.Domain.Models.Interface;

public interface IBaseModels
{
    public Guid Id { get; set; }
    public DateTime DateCreate { get; set; }
    public DateTime DateUpdate { get; set; }
}