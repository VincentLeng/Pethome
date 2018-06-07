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
    public class SqlServerCategories : ICategories
    {
        public int IntsertCategories(ICategories cate)
        {
            throw new NotImplementedException();
        }

        public int IntsertCategories(Categories cate)
        {
            string sql = "insert into Categories values(@CategoriesID,@Name,@Content)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@CategoriesID",cate.CategoriesID),
                new SqlParameter("@Name",cate.Name),
                new SqlParameter("@Content",cate.Content),

            };
            return
                DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectByProductID(int id)
        {
            string sql = "select  * from Categories where CategoriesID=@Categoriesid";
            SqlParameter[] sp = new SqlParameter[] { new SqlParameter("@CategoriesID", id) };
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectAll()
        {
            string sql = "select * from Categories ";
            return DBHelper.GetFillData(sql);
        }
    }
}
