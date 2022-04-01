using SEPUDO.Domain.Common;
using System.Linq.Expressions;

namespace SEPUDO.Application.Contracts.Persistence
{
    public interface IAsyncRepository<T> where T: BaseDomainModel
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T,bool>> predicate);
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                        string includeString=null,
                                        bool disabeldTracking=true);
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                List<Expression<Func<T,object>>> include =null,
                                string includeString = null,
                                bool disabeldTracking = true);
        Task<T> GetByIdAsync(long id);
        Task<T> AddAsync(T Entity);
        Task<T> UpdateAsync(T Entity);
        Task DeleteAsync(T Entity);

        void AddEntity(T entity);
        void UpdateEntity(T entity);
        void DeleteEntity(T entity);


    }
}
