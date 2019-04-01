using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using System.Reflection;

namespace SAA
{
    /// <summary>
    /// NHibernate helper functions to create our session that communicates with a persistence layer.
    /// Currently, we are using a MySQL database
    /// </summary>
    public class NHibernateHelper
    {
        private readonly string _connectionString;
        private ISessionFactory _sessionFactory;

        public ISessionFactory SessionFactory
        {
            get { return _sessionFactory ?? (_sessionFactory = CreateSessionFactory()); }
        }

        public NHibernateHelper(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Registers all mappings within the current assembly, creates the SessionFactory
        /// Currently, these are located within the Mappings folder in the sln.
        /// </summary>
        /// <returns></returns>
        private ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(MySQLConfiguration.Standard.ConnectionString(_connectionString))
                .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                .BuildSessionFactory();
        }
    }
}
