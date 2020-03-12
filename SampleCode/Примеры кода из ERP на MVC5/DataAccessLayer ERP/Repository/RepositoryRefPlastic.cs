using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleCode.DataAccessLayer_ERP.Repository
{
    public class RepositoryRefPlastic : AbstractRepositoryId<RefPlastic>, IRepositoryRefPlastic
    {
        public RepositoryRefPlastic() : base()
        { }
        public RepositoryRefPlastic(DbContext dbContext) : base(dbContext)
        { }
    }
}
