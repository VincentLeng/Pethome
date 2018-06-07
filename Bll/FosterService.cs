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
   public static class FosterService
    {
        private static IFoster IFoster = DataAccess.CreateFoster();

        public static int insert(Foster fos)
        {
            return IFoster.insert(fos);
        }

        public static DataTable SelectByUserID(int id)
        {
            return IFoster.SelectByUserID(id);
        }
        public static DataTable SelectTopOne()
        {
            return IFoster.selectTopOne();
        }
        public static DataTable SelectTopTwelve()
        {
            return IFoster.selectTopTwelve();
        }
        public static DataTable SelectFosterID(int FosterID)
        {
            return IFoster.SelectFosterID(FosterID);
        }
    }
}
