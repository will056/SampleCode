using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleCode.DataAccessLayer_ERP.Repository
{
    /// <summary>
    /// EF Базовые функции работы с моделью  
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class RepositoryEF<T> : IDisposable, IRepositoryEF<T> where T : class
    {
        public DbContext context { get; private set; }
        public DbSet<T> objectSet { get; private set; }

        public IQueryable<T> GetIQueryable
        {
            get { return objectSet.AsQueryable(); }
        }

        internal RepositoryEF()
            : this(new MainContext(lazyLoadingEnabled: false))
        {
            ((IObjectContextAdapter)context).ObjectContext.ContextOptions.ProxyCreationEnabled = true;
        }

        internal RepositoryEF(DbContext _context)
        {
            context = _context;
            objectSet = context.Set<T>();
        }

        public int Count(Expression<Func<T, bool>> predicate)
        {
            return objectSet.Count(predicate);
        }

        public Task<int> CountAsync(Expression<Func<T, bool>> predicate)
        {
            return objectSet.CountAsync(predicate);
        }

        public bool Any(Expression<Func<T, bool>> predicate)
        {
            return objectSet.Any(predicate);
        }
        public Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return objectSet.AnyAsync(predicate);
        }

        public virtual T Select(Expression<Func<T, bool>> predicate)
        {
            return objectSet.Where(predicate).FirstOrDefault();
        }

        public virtual List<T> Where(Expression<Func<T, bool>> predicate)
        {
            return objectSet.Where(predicate).ToList();
        }

        public virtual async Task<List<T>> WhereAsync(Expression<Func<T, bool>> predicate)
        {
            return await objectSet.Where(predicate).ToListAsync();
        }

        public virtual T First(Expression<Func<T, bool>> predicate)
        {
            return objectSet.Where(predicate).FirstOrDefault();
        }

        public virtual void AddRange(List<T> entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            objectSet.AddRange(entity);
            context.SaveChanges();
        }

        public abstract object Update(T entity);

        public virtual int Delete(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> records = objectSet.Where(predicate);
            foreach (T record in records)
            {
                objectSet.Remove(record);
            }

            return context.SaveChanges();
        }

        public virtual Task<int> DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> records = objectSet.Where(predicate);
            foreach (T record in records)
            {
                objectSet.Remove(record);
            }

            return context.SaveChangesAsync();
        }

        public abstract object Insert(T entity);

        public abstract object InsertOrUpdate(T value, object id);

        public IQueryable<T> IQueryable
        {
            get { return objectSet; }
        }
        public List<T> SelectAll()
        {
            return objectSet.ToList();
        }

        public async Task<List<T>> SelectAllAsync()
        {
            return await objectSet.ToListAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public void Delete(object id)
        {

            objectSet.Remove(SelectById(id));
            context.SaveChanges();

        }

        public async Task DeleteAsync(object id)
        {
            objectSet.Remove(await SelectByIdAsync(id));
            await context.SaveChangesAsync();
        }

        #region Абстрактные методы для работы по id модели
        public abstract T SelectById(object id);

        public abstract Task<T> SelectByIdAsync(object id);
        #endregion
    }
}
