using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace SampleCode.DataAccessLayer_ERP.Context
{
    /// <summary>
    /// Добавляю в контекст возможность работы с внешним соединением к бд
    /// </summary>
    public partial class Entities : DbContext
    {
        public Entities(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
