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
    public class SqlServerCollect : ICollect
    {
        public int insert(Collect coll)
        {
            string sql = "insert into Collect values(@CollectID,@title,@contents,@createtime)";
            SqlParameter[] sp = new SqlParameter[]{new SqlParameter("@CollectID",coll.CollectID),
                                                  new SqlParameter("@UserID",coll.UserID),
                                                 new SqlParameter("@ProductID",coll.ProductID),
                                                 new SqlParameter("@ CreateTime",coll.CreateTime)};
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectByProductsID(int id)
        {
            string sql = "select  * from Collect where CollectID=@CollectID";
            SqlParameter[] sp = new SqlParameter[] { new SqlParameter("@CollectID", id) };
            return DBHelper.GetFillData(sql);
        }

        public DataTable SelectByUserID(int id)
        {
            string sql = "select  * from Collect ";
            return DBHelper.GetFillData(sql);
        }

       
    }
    }


