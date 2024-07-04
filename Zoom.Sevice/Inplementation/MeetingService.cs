using Zoom.DAO.Repository.Intarface;
using Zoom.Domain.Models;

namespace Zoom.Sevice.Inplementation;

public class MeetingService : BaseService<Meeting>
{
    public MeetingService(IBaseRepository<Meeting?> repository) : base(repository)
    {
    }
}