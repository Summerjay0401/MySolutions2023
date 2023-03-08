using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MySolutions.Contracts;

namespace MySolutions.Repository
{
    public class NewBaseType<T> where T : class
    {
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }

    public class RepositoryBase<T> : NewBaseType<T>, IRepositoryBase<T> where T : class
    {
        protected RepositoryContext RepositoryContext;
        public RepositoryBase(RepositoryContext repositoryContext)
        => RepositoryContext = repositoryContext;
        public IQueryable<T> FindAll(bool trackChanges) =>
        !trackChanges ?
        RepositoryContext.Set<T>()
        .AsNoTracking() :
        RepositoryContext.Set<T>();
        public new IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression,
        bool trackChanges) =>
        !trackChanges ? RepositoryContext.Set<T>()
        .Where(expression)
        .AsNoTracking() :
        RepositoryContext.Set<T>()
        .Where(expression);
        public void Create(T entity) => RepositoryContext.Set<T>().Add(entity);
        public void Update(T entity) => RepositoryContext.Set<T>().Update(entity);
        public void Delete(T entity) => RepositoryContext.Set<T>().Remove(entity);
    }



}