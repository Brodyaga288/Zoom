using Microsoft.EntityFrameworkCore;
using Zoom.DAO.Repository.Intarface;
using Zoom.Domain.Models;

namespace Zoom.DAO.Repository.Inplementation;

public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseModels
{
    private readonly ApplicationContext _db;
    public BaseRepository(ApplicationContext db)
    {
        _db = db;
    }
    public async Task<ICollection<TEntity>> GetAll()
    {
        return await _db.Set<TEntity>().ToListAsync();
    }

    public async Task<TEntity?> Get(Guid id)
    {
        return await _db.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<TEntity> Create(TEntity entity)
    {
        await _db.Set<TEntity>().AddAsync(entity);
        await _db.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> Update(TEntity entity)
    {
        _db.Entry(entity).State = EntityState.Modified;
        await _db.SaveChangesAsync();
        return true;
    }

    public async Task<bool> Delete(Guid id)
    {
        var entity = await _db.Set<TEntity>().FindAsync(id);
        if (entity == null) return false;
        _db.Set<TEntity>().Remove(entity);
        await _db.SaveChangesAsync();
        return true;
    }
}