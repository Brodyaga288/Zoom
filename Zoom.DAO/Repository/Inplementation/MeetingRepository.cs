using Zoom.Domain.Models;

namespace Zoom.DAO.Repository.Inplementation;

public class MeetingRepository : BaseRepository<Meeting>
{
    public MeetingRepository(ApplicationContext db) : base(db)
    {
    }
}