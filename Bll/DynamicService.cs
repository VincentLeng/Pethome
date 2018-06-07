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
   public static class DynamicService
    {
        private static IDynamic IDynamic = DataAccess.CreateDynamic();

        public static int insertDynamic(Dynamic Dyna)
        {
            return IDynamic.insertDynamic(Dyna);
        }

        public static DataTable SelectByUserID(int id)
        {
            return IDynamic.SelectByUserID(id);
        }
    }
}
