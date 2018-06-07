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
    public class SqlServerAct : IAct
    {
        public int InsertActs(Act Act)
        {
            string sql = "insert into Act values(@UserID,@ActName,@ActContent,@Sort,@CreateTime,@EndTime,@ActLogo)";
            SqlParameter[] sp = new SqlParameter[]{new SqlParameter("@UserID",Act.UserID),
                                                   new SqlParameter("@ActName",Act.ActName),
                                                   new SqlParameter("@ActContent",Act.ActContent),
                                                   new SqlParameter("@Sort",Act.Sort),
                                                   new SqlParameter("@CreateTime",Act.CreateTime),
                                                    new SqlParameter("@ActLgo",Act.ActLogo),
                                                   new SqlParameter("@EndTime",Act.EndTime)};           
                                                   return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectByUserID(int id)
        {
            string sql = "select  * from Act where UserID=@UserID";
            SqlParameter[] sp = new SqlParameter[] { new SqlParameter("@UserID", id) };
            return DBHelper.GetFillData(sql);
        }

        public DataTable SelectTopEleven()
        {
            string sql = "select Top 11 * from Act order by CreateTime desc";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectActID(int ActID)
        {
            string sql = "select * from Act where ActID=@ActID";
            SqlParameter[] sp = new SqlParameter[]
            {
                 new SqlParameter("@ActID",ActID)
            };
            return DBHelper.GetFillData(sql, sp);
        }
    }
}
