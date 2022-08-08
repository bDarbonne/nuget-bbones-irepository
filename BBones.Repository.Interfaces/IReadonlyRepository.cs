
namespace BBones.Repository.Interfaces
{
    public interface IReadonlyRepository<T> where T : class
    {
        List<T> Get(Func<T, bool>? predicate = null);
        T? GetById(object id);
        T? FirstOrDefault(Func<T, bool> predicate);
    }
}