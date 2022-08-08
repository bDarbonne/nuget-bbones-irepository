
namespace BBones.Repository.Interfaces
{
    public interface IRepository<T> : IReadonlyRepository<T> where T : class
    {
        Task Create(T entity);
        Task Create(IEnumerable<T> entities);
        Task Update(T entity);
        Task Update(IEnumerable<T> entities);
        Task Delete(T entity);
        Task Delete(IEnumerable<T> entities);
    }
}