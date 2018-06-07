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
   public class SqlServerOrder:IOrder
    {
        public DataTable SelectTop10()
        {
            string sql = "select top 10 * from Order by TotalAmount desc";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectAll()
        {
            string sql = "select  * from Order order by TotalAmount desc";
            return DBHelper.GetFillData(sql);
        }
        public int Insert(Order order)
        {
            string sql = "insert into Order values(@OrderID,@UserID,@OrderTime,@TotalAmount,@OrderStutas,@UserAddre,@UserPhone)";
            SqlParameter[] sp = new SqlParameter[]{new SqlParameter("@OrderID",order.OrderID),
                                                   new SqlParameter("@UserID",order.UserID),
                                                   new SqlParameter("@OrderTime",order.OrderTime),
                                                   new SqlParameter("@TotalAmount",order.TotalAmount),
                                                   new SqlParameter("@OrderStutas",order.OrderStutas),
                                                   new SqlParameter("@UserAddre",order.UserAddre),
                                                   new SqlParameter("@UserPhone",order.UserPhone)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectByUserID(int id)
        {
            throw new NotImplementedException();
        }
    }
}

