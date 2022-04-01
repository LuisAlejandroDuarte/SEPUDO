using Microsoft.EntityFrameworkCore;
using SEPUDO.Application.Contracts.Persistence;
using SEPUDO.Domain.Common;
using SEPUDO.Infrastructure.Persistence;
using System.Linq.Expressions;

namespace SEPUDO.Infrastructure.Repositores
{
    public  class RepositoryBase<T>:IAsyncRepository<T> where T:BaseDomainModel
    {
        protected readonly SepudoDbContext context;

        public RepositoryBase(SepudoDbContext context)
        {
            this.context = context;
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T,bool>> predicate)
        {
            return await context.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                string includeString = null,
                                bool disabeldTracking = true)
        {
            IQueryable<T> query = context.Set<T>();
            if (disabeldTracking) query = query.AsNoTracking();
            if (!string.IsNullOrWhiteSpace(includeString)) query = query.Include(includeString);
            if (predicate != null) query = query.Where(predicate);
            if (orderBy != null)
                return await orderBy(query).ToListAsync();

            return await query.ToListAsync();

        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>>? predicate = null,
                        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                        List<Expression<Func<T, object>>>? includes = null,
                        string? includeString = null,
                        bool disabeldTracking = true)
        {
            IQueryable<T> query = context.Set<T>();
            if (disabeldTracking) query= query.AsNoTracking();
            if (includes != null) query = includes.Aggregate(query, (current, include) => current.Include(include));
            if (predicate!=null) query = query.Where(predicate);
            if (orderBy != null)
                return await orderBy(query).ToListAsync();

            return await query.ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(long Id)
        {
            return await context.Set<T>().FindAsync(Id) ;
        }

        public async Task<T> AddAsync(T entity)
        {
            context.Set<T>().Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            context.Set<T>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public void AddEntity(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public void UpdateEntity(T entity)
        {
            context.Set<T>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        public void DeleteEntity(T entity)
        {
            context.Set<T>().Remove(entity);
        }
    }
}
