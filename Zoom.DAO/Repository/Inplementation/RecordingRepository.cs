using Zoom.Domain.Models;

namespace Zoom.DAO.Repository.Inplementation;

public class RecordingRepository : BaseRepository<Recording>
{
    public RecordingRepository(ApplicationContext db) : base(db)
    {
    }
}