using Zoom.Domain.Models;

namespace Zoom.DAO.Repository.Inplementation;

public class ParticipantRepository : BaseRepository<Participant>
{
    public ParticipantRepository(ApplicationContext db) : base(db)
    {
    }
}