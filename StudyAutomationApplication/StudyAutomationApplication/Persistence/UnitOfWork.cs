using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAA.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        ISession Session { get; }
        void Commit();
        void Rollback();
    }

    /// <summary>
    /// A UnitOfWork describes an atomic database transaction
    /// IDisposable is implemented for the "using" syntax.
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ISessionFactory _sessionFactory;
        private readonly ITransaction _transaction;

        public ISession Session { get; private set; }

        public UnitOfWork(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
            Session = _sessionFactory.OpenSession();
            Session.FlushMode = FlushMode.Auto;
            _transaction = Session.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
        }

        public void Dispose()
        {
            Session.Close();
        }

        public void Commit()
        {
            if (!_transaction.IsActive)
            {
                throw new InvalidOperationException("No active transation");
            }
            _transaction.Commit();
        }

        public void Rollback()
        {
            if (_transaction.IsActive)
            {
                _transaction.Rollback();
            }
        }
    }
}
