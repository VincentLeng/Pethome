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
    public class SqlServerShoppingcart : IShoppingcart
    {
        public int insert(Shoppingcart Shoppc)
        {
            string sql = "insert into Shoppingcart values(@ShoppingID,@UserID,@ProductID,@CreateTime,@UnitPrices,@Allprices,@Quality)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ShoppingID",Shoppc.ShoppingID),
                new SqlParameter("@UserID",Shoppc.UserID),
                new SqlParameter("@ProductID",Shoppc.ProductID),
                new SqlParameter("@CreateTime",Shoppc.CreateTime),
                new SqlParameter("@UnitPrices",Shoppc.UnitPrices),
                new SqlParameter("@Allprices",Shoppc.Allprices),
                new SqlParameter("@Quality",Shoppc.Quality),
            };
            return
                DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectByProductsID(int id)
        {
            string sql = "select  * from Shoppingcart where ShoppingID=@ShoppingID";
            SqlParameter[] sp = new SqlParameter[] { new SqlParameter("@ShoppingID", id) };
            return DBHelper.GetFillData(sql);
        }

        public DataTable SelectByUserID(int id)
        {
            string sql = "select  * from Shoppingcart where UserID=@UserID";
            SqlParameter[] sp = new SqlParameter[] { new SqlParameter("@UserID", id) };
            return DBHelper.GetFillData(sql);
        }
    }
}
