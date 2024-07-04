using Zoom.Domain.Models;

namespace Zoom.DAO.Repository.Inplementation;

public class MessageRepository : BaseRepository<Message>
{
    public MessageRepository(ApplicationContext db) : base(db)
    {
    }
}