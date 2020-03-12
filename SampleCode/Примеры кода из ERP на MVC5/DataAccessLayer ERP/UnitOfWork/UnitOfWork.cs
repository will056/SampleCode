using System;

namespace SampleCode.DataAccessLayer_ERP.UnitOfWork
{
    public class UnitOfWork
    {
        public class UnitOfWork : IDisposable, IUnitOfWork
        {
            private ContextIdentity _contextIdentity;
            private ContextIdentity ContextIdentity
            {
                get
                {
                    if (_contextIdentity == null)
                    {
                        _contextIdentity = new ContextIdentity();
                    }
                    return _contextIdentity;
                }
            }

            private MainContext _mainContext;
            private MainContext MainContext
            {
                get
                {
                    if (_mainContext == null)
                    {
                        _mainContext = new MainContext();
                    }
                    return _mainContext;
                }
            }


            IRepositoryRefChip repositoryRefChip;


            public IRepositoryRefChip RepositoryRefChip
            {
                get
                {
                    if (this.repositoryRefChip == null)
                    {
                        this.repositoryRefChip = new RepositoryRefChip(MainContext);
                    }
                    return this.repositoryRefChip;
                }
            }


            IRepositoryExecutedWorksJournal repositoryExecutedWorksJournal;

            public IRepositoryExecutedWorksJournal RepositoryExecutedWorksJournal
            {
                get
                {
                    if (repositoryExecutedWorksJournal == null)
                    {
                        repositoryExecutedWorksJournal = new RepositoryExecutedWorkJournal(MainContext);
                    }
                    return repositoryExecutedWorksJournal;
                }
            }

            //и тд.
        }
    }
}
