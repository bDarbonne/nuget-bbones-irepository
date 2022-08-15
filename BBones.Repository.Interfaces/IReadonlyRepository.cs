using System.Linq.Expressions;

namespace BBones.Repository.Interfaces
{
    public interface IReadonlyRepository<T> where T : class
    {
        Task<List<T>> Get(Func<T, bool>? predicate = null);
        Task<T?> FirstOrDefault(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);
        ValueTask<T?> GetById(object id);
    }
}