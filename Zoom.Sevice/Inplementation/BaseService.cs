using Zoom.DAO.Repository.Intarface;
using Zoom.Domain.Models;
using Zoom.Sevice.Interface;

namespace Zoom.Sevice.Inplementation;

public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseModels
{
    private readonly IBaseRepository<TEntity?> _repo;
    
    public BaseService(IBaseRepository<TEntity?> repository)
    {
        _repo = repository;
    }
    public async Task<IEnumerable<TEntity?>> GetAll()
    {
        try
        {
           return await _repo.GetAll();
        }
        catch
        {
            throw new Exception("Нет пользователей");
        }
    }

    public async Task<TEntity?> Get(Guid id)
    {
        try
        {
            return await _repo.Get(id);
        }
        catch
        {
            throw new Exception("Такого пользователя не существует");
        }
    }

    public async Task<TEntity> Create(TEntity entity)
    {
        try
        {
            return await _repo.Create(entity);
        }
        catch
        {
            throw new Exception("Обьект не может быть создан");
        }
    }

    public async Task<bool> Update(TEntity entity)
    {
        try
        {
            return await _repo.Update(entity);
        }
        catch
        {
            throw new Exception("Не возможно обновить");
        }
    }

    public async Task<bool> Delete(Guid id)
    {
        try
        {
            return await _repo.Delete(id);
        }
        catch
        {
            throw new Exception("Не возможно удалить");
        }
    }
}