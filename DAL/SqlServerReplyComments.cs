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
    public class SqlServerReplyComments:IReplyComments
    {
        public DataTable SelectByeplyComID(int id)
        {
            string sql = "select  * from ReplyComments ";
            return DBHelper.GetFillData(sql);
        }
        public int InsertReplyComments(ReplyComments replycoms)
        {
            string sql = "insert into ReplyComments values(@ComID,@UserID,@ReplyComContent,@ReplyComTime)";
            SqlParameter[] sp = new SqlParameter[]{
                                                  new SqlParameter("@ComID",replycoms.ComID),
                                                 new SqlParameter("@UserID",replycoms.UserID),
                                                 new SqlParameter("@ReplyComContent",replycoms.ReplyComContent),
                                                 new SqlParameter("@ReplyComTime",replycoms.ReplyComTime),};
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
        //留言
        public DataTable SelectReplyComments(int ComID)
        {
            string sql = @"select ReplyComments.*,a.UserName as 回复人,b.UserName as 被回复人 
                           from UserInfo a,UserInfo b,ReplyComments,Comments 
                           where a.UserID=ReplyComments.UserID 
                             and b.UserID=Comments.UserID 
                             and ReplyComments.ComID=Comments.ComID 
                             and Comments.ComID=@ComID";
            SqlParameter[] para = { new SqlParameter("@ComID", ComID) };
            return DBHelper.GetFillData(sql, para);
        }
        public DataTable SelectAllReplyComments()
        {
            string sql = "select ReplyComments.*,a.UserName as 回复者,b.UserName as 被回复者 from UserInfo a,UserInfo b,ReplyComments,Comments where a.UserID=ReplyComments.UserID and b.UserID=Comments.UserID and ReplyComments.ComID=Comments.ComID ";
            return DBHelper.GetFillData(sql);
        }
        public int DeleteReplyComments(int ReplyComID)
        {
            string sql = "delete from ReplyComments where ReplyComID=@ReplyComID";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ReplyComID",ReplyComID)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
    }
}
