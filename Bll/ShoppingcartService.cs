using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using IDAL;
using DALFactory;
using System.Data.SqlClient;
using System.Data;


namespace Bll
{
    public class ShoppingcartService 
    {
        private static IShoppingcart IShoppingcart =DataAccess.CreateShoppingcart() ;
        public int insert(Shoppingcart Shoppc)
        {
            return IShoppingcart.insert(Shoppc);
        }

        public DataTable SelectByProductsID(int id)
        {
            return IShoppingcart.SelectByProductsID(id);
        }

        public DataTable SelectByUserID(int id)
        {
            return IShoppingcart.SelectByUserID(id);
        }
    }
}
