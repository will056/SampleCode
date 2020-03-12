using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace SampleCode.DataAccessLayer_ERP.Repository
{
    public class RepositoryOPIWorkJournal : AbstractRepositoryId<OPIWorkJournal>, IRepositoryOPIWorkJournal
    {
        public RepositoryOPIWorkJournal(DbContext context) : base(context)
        { }
    }
}
