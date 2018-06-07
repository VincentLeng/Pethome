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
    public class SqlServerProducts : IProducts
    {
        public int insert(Products prod)
        {
            string sql = "insert into Products values(@ProductID,@ProName ,@ CategoriesID,@Prices,@Sales,@Information,@UserID ,@ProdPhoto)";
            SqlParameter[] sp = new SqlParameter[]{new SqlParameter("@ProductID",prod.ProductID),
                                                   new SqlParameter("@ProName",prod.ProName),
                                                   new SqlParameter("@CategoriesID",prod.CategoriesID),
                                                   new SqlParameter("@Prices",prod.Prices),
                                                   new SqlParameter("@Sales",prod.Sales),
                                                   new SqlParameter("@Information",prod.Information),
                                                   new SqlParameter("@UserID",prod.UserID),
                                                   new SqlParameter("@ProdPhoto",prod.ProdPhoto),
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectAll()
        {
            string sql = "select  * from Products order by Sales desc";
            return DBHelper.GetFillData(sql);
        }

        public DataTable SelectTop()
        {
            throw new NotImplementedException();
        }

        public DataTable SelectTop(int id)
        {
            string sql = "select  * from Products where ProductID=@ProductID";
            SqlParameter[] sp = new SqlParameter[] { new SqlParameter("@ProductID", id) };
            return DBHelper.GetFillData(sql);
        }
    }
}
