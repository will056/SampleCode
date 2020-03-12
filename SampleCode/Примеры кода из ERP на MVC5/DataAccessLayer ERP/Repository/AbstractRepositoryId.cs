using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleCode.DataAccessLayer_ERP.Repository
{
    /// <summary>
    /// Репозиторий для моделей с int Id
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractRepositoryId<T> : RepositoryEF<T>, IAbstractRepositoryId<T> where T : class, IId
    {
        public AbstractRepositoryId() : base()
        {
        }

        public AbstractRepositoryId(DbContext context) : base(context)
        {
        }

        public override T SelectById(object id)
        {
            return objectSet.FirstOrDefault(u => u.Id == (int)id);
        }

        public override Task<T> SelectByIdAsync(object id)
        {
            return objectSet.FirstOrDefaultAsync(u => u.Id == (int)id);
        }

        public override object Insert(T entity)
        {
            objectSet.Add(entity);
            context.SaveChanges();

            return entity.Id;
        }

        public async Task<int> InsertAsync(T entity)
        {
            objectSet.Add(entity);
            await context.SaveChangesAsync();

            return entity.Id;
        }

        public override object Update(T entity)
        {
            var item = objectSet.Find(entity.Id);

            context.Entry(item).CurrentValues.SetValues(entity);
            context.SaveChanges();

            return entity.Id;
        }

        public async Task<int> UpdateAsync(T entity)
        {
            var item = objectSet.Find(entity.Id);

            context.Entry(item).CurrentValues.SetValues(entity);
            await context.SaveChangesAsync();

            return entity.Id;
        }

        public override object InsertOrUpdate(T value, object id)
        {
            var item = objectSet.Find(id);
            if (item == null)
            {
                return Insert(value);
            }
            else
            {
                return Update(value);
            }
        }
    }
}
