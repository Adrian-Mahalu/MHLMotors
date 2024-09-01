using MHL_Motors.DataAccess.DatabaseContext;
using MHL_Motors.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MHL_Motors.DataAccess.Repositories.Implementations
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public IQueryable<T> GetQueriable()
        {
            return _context.Set<T>();
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
