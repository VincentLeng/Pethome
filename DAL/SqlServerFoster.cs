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
    public class SqlServerFoster : IFoster
    {
        public int insert(Foster fos)
        {
            string sql = "insert into Foster values(@FosterID ,@UserID,@FosterAdd ,@FosterTime,@FosterUserPhone,@FosterContent,@FosterStatus，@FosterPetPhoto)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@FosterID",fos.FosterID),
                new SqlParameter("@UserID",fos.UserID),
                new SqlParameter("@UserAdd",fos.FosterAdd),
                new SqlParameter("@FosterTime",fos.FosterTime),
                new SqlParameter("@UserPhone",fos.FosterUserPhone),
                new SqlParameter("@FContent",fos.FosterContent),
                new SqlParameter("@FStatus",fos.FosterStatus),
                new SqlParameter("@PetPhoto",fos.FosterPetPhoto),
            };
            return
                DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectByUserID(int id)
        {
              string sql = "select  * from Foster where FosterID=@FosterID";
            SqlParameter[] sp = new SqlParameter[] { new SqlParameter("@FosterID", id) };
            return DBHelper.GetFillData(sql);
        }
        public DataTable selectTopOne()
        {
            string sql = "select Top 1 * from Foster order by FosterTime desc";
            return DBHelper.GetFillData(sql);
        }
        public DataTable selectTopTwelve()
        {
            string sql = "select Top 12 * from Foster order by FosterTime desc";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectFosterID(int FosterID)
        {
            string sql = "select * from Foster where FosterID=@FosterID";
            SqlParameter[] sp = new SqlParameter[]
            {
                 new SqlParameter("@FosterID",FosterID)
            };
            return DBHelper.GetFillData(sql, sp);
        }
    }
}
