using Database.Entities.Base;
using System.Linq.Expressions;

namespace API.Repository
{
    public interface IRepository<TEntity, TKey> where TEntity : Entity
    {
        Task<TEntity> GetEntity(TKey id);
        Task<TEntity> GetEntity(Expression<Func<TEntity, bool>> expression);
        Task<IEnumerable<TEntity>> GetAllEntities(int take = int.MaxValue);
        Task<IEnumerable<TEntity>> GetAllEntities(Expression<Func<TEntity, bool>> expression, int take = int.MaxValue);
        Task<bool> Exists(Expression<Func<TEntity, bool>> expression);
        Task CreateEntity(TEntity entity);
        Task UpdateEntity(TEntity entity);
        Task DeleteEntity(TKey id);
    }
}
