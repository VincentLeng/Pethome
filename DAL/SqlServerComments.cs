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
    public class SqlServerComments : IComments
    {
        public int insert(Comments Comm)
        {
            string sql = "insert into Comments values(@ComTime,@ComContent,@UserID,@ActID)";
            SqlParameter[] sp = new SqlParameter[]{
                                                  new SqlParameter("@ComTime",Comm.ComTime),
                                                 new SqlParameter("@ComContent",Comm.ComContent),
                                                 new SqlParameter("@UserID",Comm.UserID),
                                                 new SqlParameter("@ActID",Comm.ActID),};
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectByActID(int id)
        {
            string sql = "select  * from Comments where ComID=@ComID";
            SqlParameter[] sp = new SqlParameter[] { new SqlParameter("@ComID", id) };
            return DBHelper.GetFillData(sql,sp);
        }

        public DataTable SelectByUserID(int id)
        {
            string sql = "select  * from Comments ";
            return DBHelper.GetFillData(sql);

        }
        //评论
        public DataTable SelectComments(int ActID)
        {
            string sql = "select a.*,b.UserName from Comments a,UserInfo b where ActID='" + ActID + "' and a.UserID=b.UserID order by ComTime desc";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("ActID",ActID)
            };
            return DBHelper.GetFillData(sql, sp);
        }
        public DataTable SelectAllComments()
        {
            string sql = "select a.*,b.UserName,c.ActName from Comments a,UserInfo b,Act c where a.UserID=b.UserID and a.ActID=c.ActID";
            return DBHelper.GetFillData(sql);
        }
        public int DeleteComments(int ComID)
        {
            string sql = "delete from ReplyComments where ComID=@ComID delete from Comments where ComID=@ComID";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ComID",ComID)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
    }
}
