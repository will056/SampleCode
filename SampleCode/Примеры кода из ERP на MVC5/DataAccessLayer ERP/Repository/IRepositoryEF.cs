using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleCode.DataAccessLayer_ERP.Repository
{
    public interface IRepositoryEF<T> where T : class
    {
        DbContext context { get; }
        IQueryable<T> GetIQueryable { get; }
        IQueryable<T> IQueryable { get; }
        DbSet<T> objectSet { get; }

        void AddRange(List<T> entity);
        bool Any(Expression<Func<T, bool>> predicate);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        int Count(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);
        int Delete(Expression<Func<T, bool>> predicate);
        void Delete(object id);
        Task<int> DeleteAsync(Expression<Func<T, bool>> predicate);
        Task DeleteAsync(object id);
        void Dispose();
        T First(Expression<Func<T, bool>> predicate);
        T Select(Expression<Func<T, bool>> predicate);
        List<T> SelectAll();
        Task<List<T>> SelectAllAsync();
        List<T> Where(Expression<Func<T, bool>> predicate);
        Task<List<T>> WhereAsync(Expression<Func<T, bool>> predicate);
    }
}
