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
    public class SqlServerDynamic : IDynamic
    {
        public int insertDynamic(Dynamic Dyna)
        {
            string sql = "insert into Dynamic values(@DynamicID,@DyContent,@CreateTime,@UserID)";
            SqlParameter[] sp = new SqlParameter[]{new SqlParameter("@DynamicID",Dyna.DynamicID),
                                                  new SqlParameter("@DyContent",Dyna.DyContent),
                                                 new SqlParameter("@CreateTime",Dyna.CreateTime),
                                                 new SqlParameter("@UserID",Dyna.UserID)};
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectByUserID(int id)
        {
            string sql = "select  * from Dynamic ";
            return DBHelper.GetFillData(sql);
        }
    }
}
