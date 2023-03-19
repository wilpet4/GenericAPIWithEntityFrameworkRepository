using Database.Context;
using Database.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace API.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly DatabaseContext _context;

        public Repository(DatabaseContext context)
        {
            _context = context;
        }
        public virtual async Task<T> GetEntity(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            return entity;
        }
        public virtual async Task<T> GetEntity(Expression<Func<T, bool>> expression)
        {
            var result = await _context.Set<T>().Where(expression).FirstAsync();

            return result;
        }
        public virtual async Task<IEnumerable<T>> GetAllEntities(int take = int.MaxValue)
        {
            var entities = await _context.Set<T>().Take(take).ToListAsync();

            return entities;
        }
        public virtual async Task<IEnumerable<T>> GetAllEntities(Expression<Func<T, bool>> expression, int take = int.MaxValue)
        {
            var result = await _context.Set<T>().Where(expression).Take(take).ToListAsync();

            return result;
        }
        public virtual async Task CreateEntity(T entity)
        {
            _context.Set<T>().Add(entity);

            await _context.SaveChangesAsync();
        }
        public virtual async Task UpdateEntity(T entity)
        {
            _context.Set<T>().Update(entity);

            await _context.SaveChangesAsync();
        }
        public virtual async Task DeleteEntity(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            _context.Set<T>().Remove(entity);

            await _context.SaveChangesAsync();
        }
        public virtual async Task<bool> Exists(Expression<Func<T, bool>> expression)
        {
            var result = await _context.Set<T>().Where(expression).AnyAsync();

            return result;
        }
    }
}
