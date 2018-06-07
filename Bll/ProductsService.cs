using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using IDAL;
using DAL;
using DALFactory;
using System.Data.SqlClient;
using System.Data;

namespace Bll
{
    public static class ProductsService
    {
        private static IProducts IProducts = DataAccess.CreateProducts();

        public static int insert(Products Prod)
        {
            return IProducts.insert(Prod);
        }

        public static DataTable SelectAll()
        {
            return IProducts.SelectAll();
        }

        public static  DataTable SelectTop()
        {
            return IProducts.SelectTop();
        }
    }
}
