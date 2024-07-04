using Zoom.Domain.Models;

namespace Zoom.DAO.Repository.Inplementation;

public class ChatRepository : BaseRepository<Chat>
{
    public ChatRepository(ApplicationContext db) : base(db)
    {
    }
}