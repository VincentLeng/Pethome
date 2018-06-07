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
    public class SqlServerFind : IFind
    {
        public int insert(Find fin)
        {
            string sql = "insert into Find values(@UserID,@FindAdd ,@FindTime,@FindUserPhone,@FindContent,@FindStatus,@FindPetPhoto)";
            SqlParameter[] sp = new SqlParameter[]{
                                                   new SqlParameter("@UserID",fin.UserID),
                                                   new SqlParameter("@FindAdd",fin.FindAdd),
                                                   new SqlParameter("@FindTime",fin.FindTime),
                                                   new SqlParameter("@FindUserPhone",fin.FindUserPhone),
                                                   new SqlParameter("@FindContent",fin.FindContent),
                                                   new SqlParameter("@FindStatus",fin.FindStatus),
                                                   new SqlParameter("@FindPetPhoto",fin.FindPetPhoto) };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectByUserID(int id)
        {
            string sql = "select  * from Find where FindID=@FindID";

            SqlParameter[] sp = new SqlParameter[] { new SqlParameter("@FindID", id) };
            return DBHelper.GetFillData(sql);
        }

        public DataTable selectTopOne()
        {
            string sql = "select Top 1 * from Find order by FindTime desc";
            return DBHelper.GetFillData(sql);
        }
        public DataTable selectTopTwelve()
        {
            string sql = "select Top 12 * from Find order by FindTime desc";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectFindID(int FindID)
        {
            string sql = "select * from Find where FindID=@FindID";
            SqlParameter[] sp = new SqlParameter[]
            {
                 new SqlParameter("@FindID",FindID)
            };
            return DBHelper.GetFillData(sql, sp);
    }

    }
}
