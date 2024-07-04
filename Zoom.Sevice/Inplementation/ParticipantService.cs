using Zoom.DAO.Repository.Intarface;
using Zoom.Domain.Models;

namespace Zoom.Sevice.Inplementation;

public class ParticipantService : BaseService<Participant>
{
    public ParticipantService(IBaseRepository<Participant?> repository) : base(repository)
    {
    }
}