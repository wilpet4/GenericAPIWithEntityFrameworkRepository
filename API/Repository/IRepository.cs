using Database.Entities.Base;
using System.Linq.Expressions;

namespace API.Repository
{
    public interface IRepository<T> where T : Entity
    {
        Task<T> GetEntity(int id);
        Task<T> GetEntity(Expression<Func<T, bool>> expression);
        Task<IEnumerable<T>> GetAllEntities(int take = int.MaxValue);
        Task<IEnumerable<T>> GetAllEntities(Expression<Func<T, bool>> expression, int take = int.MaxValue);
        Task<bool> Exists(Expression<Func<T, bool>> expression);
        Task CreateEntity(T entity);
        Task UpdateEntity(T entity);
        Task DeleteEntity(int id);
    }
}
