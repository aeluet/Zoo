using System.Linq.Expressions;

namespace Zoo.Repository.IRepository
{
    public interface IRepository<T> where T :class
    {
        //T - Arraza
        IEnumerable<T> GetAll(string? includeProperties = null);
        T Get(Expression<Func<T, bool>> filter, string? includePropertier = null);
        IEnumerable<T> GetPartial(Expression<Func<T, bool>> filter, string? includeProperties = null);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}
