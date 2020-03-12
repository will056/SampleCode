using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleCode.DataAccessLayer_ERP.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepositoryUser RepositoryUser { get; }
        IRepositoryExecutedWorksJournal RepositoryExecutedWorksJournal { get; }
        IRepositoryAllMechanicJournal RepositoryAllMechanicJournal { get; }
        IRepositoryAllMechinecsJournalWork RepositoryAllMechinecsJournalWork { get; }
        IRepositoryMechanicJournal RepositoryMechanicJournal { get; }
        IRepositoryMechanicOrderWork RepositoryMechanicOrderWork { get; }
        IRepositoryRefChip RepositoryRefChip { get; }
        ...
    }
}
