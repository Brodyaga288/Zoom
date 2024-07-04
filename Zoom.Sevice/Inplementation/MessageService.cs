using Zoom.DAO.Repository.Intarface;
using Zoom.Domain.Models;

namespace Zoom.Sevice.Inplementation;

public class MessageService : BaseService<Message>
{
    public MessageService(IBaseRepository<Message?> repository) : base(repository)
    {
    }
}