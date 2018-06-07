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
    public static class OrderService 
    {
        private static IOrder IOrder = DataAccess.CreateOrder();
        public static DataTable SelectByUserID(int id)
        {
            return IOrder.SelectByUserID(id);
        }
    }
}
