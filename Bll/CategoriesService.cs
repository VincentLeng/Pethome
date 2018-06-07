using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using DAL;
using DALFactory;
using System.Data.SqlClient;
using System.Data;
using Models;

namespace Bll
{
   public static class CategoriesService
    {
        private static ICategories ICategories = DataAccess.CreateCategories();

        public static int IntsertCategories(ICategories cate)
        {
            return ICategories.IntsertCategories(cate);
        }

        public static DataTable SelectByProductID(int id)
        {
            return ICategories.SelectByProductID(id);
        }
        public static DataTable SelectAll()
        {
            return ICategories.SelectAll();
        }
    }
}
