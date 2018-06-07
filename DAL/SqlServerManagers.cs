using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using IDAL;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class SqlServerManagers : IManagers
    {
        public int Insert(Managers mag)
        {
            string sql = "insert into Managers values(@ManagerID ,@ManagerName,@Password )";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ManagerID", mag.ManagerID ),
                new SqlParameter("@ManagerName", mag.ManagerName),
                new SqlParameter("@Password", mag.Password),


            };
            return
                DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public SqlDataReader Login(int name, string pwd)
        {
            throw new NotImplementedException();
        }
    }
}
