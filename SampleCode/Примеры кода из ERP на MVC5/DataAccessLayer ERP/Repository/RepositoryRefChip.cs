using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleCode.DataAccessLayer_ERP.Repository
{
    public class RepositoryRefChip : AbstractRepositoryId<RefChip>, IRepositoryRefChip
    {
        public RepositoryRefChip(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
