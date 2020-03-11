using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.DataAccessLayer_ERP.Repository
{
    /// <summary>
    /// EF Базовые функции работы с моделью  
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class RepositoryEF<T> : IRepository<T>, IDisposable where T : class
    {
        public DbContext context { get; private set; }
        protected DbSet<T> objectSet;

        internal RepositoryEF(bool ProxyCreationEnabled = true)
            : this(new Entities())
        {
            ((IObjectContextAdapter)context).ObjectContext.ContextOptions.ProxyCreationEnabled = ProxyCreationEnabled;
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

        public virtual T First(Expression<Func<T, bool>> predicate)
        {
            return objectSet.Where<T>(predicate).FirstOrDefault();
        }

        public virtual List<T> Where(Expression<Func<T, bool>> predicate)
        {
            return objectSet.Where<T>(predicate).ToList();
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

        public virtual void Delete(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> records = objectSet.Where<T>(predicate);
            foreach (T record in records)
            {
                objectSet.Remove(record);
            }

            context.SaveChanges();
        }

        public abstract object Insert(T entity);

        public abstract object InsertOrUpdate(T value, object id);

        public IQueryable<T> SelectAllIQueryable()
        {
            return objectSet;
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

        public Task DeleteAsync(object id)
        {
            objectSet.Remove(SelectById(id));
            return context.SaveChangesAsync();
        }

        #region Абстрактные методы для работы по id модели
        public abstract T SelectById(object id);

        public abstract Task<T> SelectByIdAsync(object id);
        #endregion
    }
}
