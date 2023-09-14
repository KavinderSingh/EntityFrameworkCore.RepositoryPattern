using System.Linq.Expressions;

namespace EntityFrameworkCore.RepositoryPattern.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T? Get(int id);
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        Task Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(int id);
        void RemoveRange(IEnumerable<T> entities);
        Task<int> SaveAsync();
        Task<int> Count(Expression<Func<T, bool>> expression);
        void Update(T entity);
    }
}
