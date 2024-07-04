using Zoom.DAO.Repository.Intarface;
using Zoom.Domain.Models;

namespace Zoom.Sevice.Inplementation;

public class RecordingService : BaseService<Recording>
{
    public RecordingService(IBaseRepository<Recording?> repository) : base(repository)
    {
    }
}