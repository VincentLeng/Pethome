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
    public static class CollectService
    {
        private static ICollect ICollect = DataAccess.CreateCollect();

        public static int insert(Collect coll)
        {
            return ICollect.insert(coll);
        }

        public static DataTable SelectByProductsID(int id)
        {
            return ICollect.SelectByProductsID(id);
        }

        public static DataTable SelectByUserID(int id)
        {
            return ICollect.SelectByUserID(id);
        }
    }
}
