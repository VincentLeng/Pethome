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
    public static class FoundService
    {
        private static IFound IFound = DataAccess.CreateFound();

        public static int insert(Found fou)
        {
            return IFound.insert(fou);
        }

        public static DataTable SelectByUserID(int id)
        {
            return IFound.SelectByUserID(id);
        }
        public static DataTable SelectTopOne()
        {
            return IFound.selectTopOne();
        }
        public static DataTable SelectTopTwelve()
        {
            return IFound.selectTopTwelve();
        }
        public static DataTable SelectFoundID(int FoundID)
        {
            return IFound.SelectFoundID(FoundID);
        }
    }
} 
