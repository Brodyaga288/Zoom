using System.Diagnostics;
using Zoom.Domain.Models;

namespace Zoom.DAO.Repository.Intarface;

public interface IBaseRepository<TEntity> where TEntity : BaseModels
{
    public Task<ICollection<TEntity>> GetAll();
    public Task<TEntity?> Get(Guid id);
    public Task<TEntity> Create(TEntity entity);
    public Task<bool> Update(TEntity entity);
    public Task<bool> Delete(Guid id);
}