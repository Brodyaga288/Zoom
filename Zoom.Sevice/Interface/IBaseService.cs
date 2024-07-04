using Zoom.Domain.Models;

namespace Zoom.Sevice.Interface;

public interface IBaseService<TEntity> where TEntity : BaseModels
{
    public Task<IEnumerable<TEntity?>> GetAll();
    public Task<TEntity?> Get(Guid id);
    public Task<TEntity> Create(TEntity entity);
    public Task<bool> Update(TEntity entity);
    public Task<bool> Delete(Guid id);
}