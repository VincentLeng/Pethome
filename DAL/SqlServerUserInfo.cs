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
    public class SqlServerUserInfo : IUserInfo
    {

        public int Insert(UserInfo us)
        {
            string sql = "insert into UserInfo values(@UserName,@Password,@UserPhone,@Email)";
            SqlParameter[] sp = new SqlParameter[]
            {
              
                new SqlParameter("@UserName",us.UserName),
                new SqlParameter("@Password",us.Password),
                new SqlParameter("@UserPhone",us.UserPhone),
                new SqlParameter("@Email",us.Email),

            };
            return
                DBHelper.GetExcuteNonQuery(sql, sp);
        }
        public SqlDataReader Login(string name, string pwd)
        {
            string sql = "select * from UserInfo where UserName=@UserName and Password=@Password";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@UserName",name),
                new SqlParameter("@Password",pwd)
            };
            return DBHelper.GetDataReader(sql, sp);
        }

    }
}
