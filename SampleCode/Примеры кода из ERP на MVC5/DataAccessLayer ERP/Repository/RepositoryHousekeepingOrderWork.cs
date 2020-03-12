using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleCode.DataAccessLayer_ERP.Repository
{
    public class RepositoryHousekeepingOrderWork : RepositoryEF<HousekeepingOrderWork>, IRepositoryHousekeepingOrderWork
    {
        public RepositoryHousekeepingOrderWork(DbContext context) : base(context)
        { }

        public override object Insert(HousekeepingOrderWork entity)
        {
            objectSet.Add(entity);
            context.SaveChanges();
            return entity.Id;
        }

        public override object InsertOrUpdate(HousekeepingOrderWork value, object id)
        {
            if (objectSet.Any(u => u.Id == (int)id))
                return Update(value);
            else
                return Insert(value);
        }

        public override HousekeepingOrderWork SelectById(object id)
        {
            return objectSet.FirstOrDefault(u => u.Id == (int)id);
        }

        public override Task<HousekeepingOrderWork> SelectByIdAsync(object id)
        {
            return objectSet.FirstOrDefaultAsync(u => u.Id == (int)id);
        }

        public override object Update(HousekeepingOrderWork entity)
        {
            var value = SelectById(entity.Id);

            context.Entry(value).CurrentValues.SetValues(entity);
            context.SaveChanges();
            return entity.Id;
        }
    }
}
