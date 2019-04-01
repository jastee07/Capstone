using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SAA.Models;

namespace SAA.Persistence
{
    public class DatabaseOperations
    {
        private NHibernateHelper helper;

        public DatabaseOperations()
        {
            // TODO: Read connection string from config
            helper = new NHibernateHelper("Server=127.0.0.1;Database=EKPC_Facilities;Uid=user;Pwd=pass;");
        }

        public List<Branch> GetBranches()
        {
            using(var unitOfWork = new UnitOfWork(helper.SessionFactory))
            {
                return unitOfWork.Session.Query<Branch>().ToList();
            }
        }
    }
}
