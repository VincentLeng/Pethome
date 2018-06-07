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
    public class SqlServerFound : IFound
    {
        public int insert(Found fou)
        {
            string sql = "insert into Found values(@FoundID,@UserID,@FoundLostAdd,@FoundLostTime,@FoundUserPhone,@FoundContent,@FoundStutas,@FoundPetPhoto)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@FoundID",fou.FoundID),
                new SqlParameter("@UserID",fou.UserID),
                new SqlParameter("@LostAdd",fou.FoundLostAdd),
                new SqlParameter("@LostTime",fou.FoundLostTime),
                new SqlParameter("@UserPhone",fou.FoundUserPhone),
                new SqlParameter("@FContent",fou.FoundContent),
                new SqlParameter("@FStutas",fou.FoundStatus),
                new SqlParameter("@PetPhoto",fou.FoundPetPhoto),
            };
            return
                DBHelper.GetExcuteNonQuery(sql, sp);
        }
        public DataTable SelectByUserID(int id)
        {
            string sql = "select  * from Found where FoundID=@FoundID";

            SqlParameter[] sp = new SqlParameter[] { new SqlParameter("@FoundID", id) };
            return DBHelper.GetFillData(sql);
        }

        public DataTable selectTopOne()
        {
            string sql = "select Top 1 * from Found order by FoundLostTime desc";
            return DBHelper.GetFillData(sql);
        }
        public DataTable selectTopTwelve()
        {
            string sql = "select Top 12 * from Found order by FoundLostTime desc";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectFoundID(int FoundID)
        {
            string sql = "select * from Found where FoundID=@FoundID";
            SqlParameter[] sp = new SqlParameter[]
            {
                 new SqlParameter("@FoundID",FoundID)
            };
            return DBHelper.GetFillData(sql, sp);
        }
    }
}
