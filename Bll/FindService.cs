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
    public static class FindService
    {
        private static IFind IFind = DataAccess.CreateFind();

        public static int insert(Find fin)
        {
            return IFind.insert(fin);
        }
        public static DataTable SelectTopOne()
        {
            return IFind.selectTopOne();
        }
        public static DataTable SelectByUserID(int id)
        {
            return IFind.SelectByUserID(id);
        }
        public static DataTable SelectTopTwelve()
        {
            return IFind.selectTopTwelve();
        }
        public static DataTable SelectFindID(int FindID)
        {
            return IFind.SelectFindID(FindID);
        }
    }
}
