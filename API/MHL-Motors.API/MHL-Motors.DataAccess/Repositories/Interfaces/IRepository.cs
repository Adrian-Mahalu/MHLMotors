namespace MHL_Motors.DataAccess.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T?> GetByIdAsync(Guid id);
        IQueryable<T> GetQueriable();
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task SaveChangesAsync();
        //void InsertRange(IEnumerable<T> entities);
    }
}
