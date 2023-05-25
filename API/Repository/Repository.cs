using Database.Context;
using Database.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace API.Repository
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : Entity
    {
        protected readonly DatabaseContext _context;

        public Repository(DatabaseContext context)
        {
            _context = context;
        }
        public virtual async Task<TEntity> GetEntity(TKey id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);

            return entity;
        }
        public virtual async Task<TEntity> GetEntity(Expression<Func<TEntity, bool>> expression)
        {
            var result = await _context.Set<TEntity>().Where(expression).FirstAsync();

            return result;
        }
        public virtual async Task<IEnumerable<TEntity>> GetAllEntities(int take = int.MaxValue)
        {
            var entities = await _context.Set<TEntity>().Take(take).ToListAsync();

            return entities;
        }
        public virtual async Task<IEnumerable<TEntity>> GetAllEntities(Expression<Func<TEntity, bool>> expression, int take = int.MaxValue)
        {
            var result = await _context.Set<TEntity>().Where(expression).Take(take).ToListAsync();

            return result;
        }
        public virtual async Task CreateEntity(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);

            await _context.SaveChangesAsync();
        }
        public virtual async Task UpdateEntity(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);

            await _context.SaveChangesAsync();
        }
        public virtual async Task DeleteEntity(TKey id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);

            _context.Set<TEntity>().Remove(entity);

            await _context.SaveChangesAsync();
        }
        public virtual async Task<bool> Exists(Expression<Func<TEntity, bool>> expression)
        {
            var result = await _context.Set<TEntity>().Where(expression).AnyAsync();

            return result;
        }
    }
}
