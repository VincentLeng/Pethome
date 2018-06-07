using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using DAL;
using DALFactory;
using System.Data.SqlClient;
using System.Data;
using Models;

namespace Bll
{
    public static class ManagersService
    {
        private static IManagers IManagers = DataAccess.CreateManagers();

        public static  int Insert(Managers us)
        {
            return IManagers.Insert(us);
        }

        public static SqlDataReader Login(int name, string pwd)
        {
            return IManagers.Login(name, pwd);
        }
    }
}
