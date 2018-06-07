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
    public static class ActService
    {
        private static IAct IAct = DataAccess.CreateAct();

        public static int InsertActs(Act Act)
        {
            return IAct.InsertActs(Act);
        }

        public static DataTable SelectByUserID(int id)
        {
            return IAct.SelectByUserID(id);
        }
        public static DataTable SelectTopEleven()
        {
            return IAct.SelectTopEleven();
        }
        public static DataTable SelectActID(int ActID)
        {
            return IAct.SelectActID(ActID);
        }
    }
}
