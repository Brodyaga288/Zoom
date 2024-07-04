using Zoom.DAO.Repository.Intarface;
using Zoom.Domain.Models;

namespace Zoom.Sevice.Inplementation;

public class ChatService : BaseService<Chat>
{
    public ChatService(IBaseRepository<Chat?> repository) : base(repository)
    {
    }
}