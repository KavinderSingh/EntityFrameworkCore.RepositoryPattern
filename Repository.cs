using EntityFrameworkCore.RepositoryPattern.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EntityFrameworkCore.RepositoryPattern
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly dynamic _context;

        public Repository(dynamic context)
        {
            _context = context;
        }

        public async Task Add(T entity)
        {
            _ = await _context.Set<T>().AddAsync(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public async Task<int> Count(Expression<Func<T, bool>> expression)
        {
            return await _context.Set<T>().CountAsync(expression);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

        public T? Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {

            return _context.Set<T>();

        }

        public void Remove(int id)
        {
            T? entityToDelete = _context.Set<T>().Find(id);
            _ = _context.Set<T>().Remove(entityToDelete!);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}