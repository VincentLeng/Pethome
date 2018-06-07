using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using IDAL;
using System.Reflection;
using System.Configuration;
using System.Data.SqlClient;


namespace DALFactory
{
     public class DataAccess
    {
        private static string AssemblyName = ConfigurationManager.AppSettings["Path"].ToString();
        private static string db = ConfigurationManager.AppSettings["DB"].ToString();
        public static IUserInfo CreateUser()
        {
            string className = AssemblyName + "." + db + "UserInfo";
            return (IUserInfo)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IShoppingcart CreateShoppingcart()
        {
            string className = AssemblyName + "." + db + "Shoppingcart";
            return (IShoppingcart)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IReplyComments CreateReplyComments()
        {
            string className = AssemblyName + "." + db + "ReplyComments";
            return (IReplyComments)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        //public static IReplyComments CreateReplyComments()
        //{
        //    string className = AssemblyName + "." + db + "ReplyComments";
        //    //string className = AssemblyName + ".SqlServerReplyComments";
        //    IReplyComments ireply = null;

        //    try
        //    {
        //        ireply = (IReplyComments)Assembly.Load(AssemblyName).CreateInstance(className);
        //    }
        //    catch (Exception ex)
        //    {

        //    }

        //    return ireply;
        //}
        public static IProducts CreateProducts()
        {
            string className = AssemblyName + "." + db + "Products";
            return (IProducts)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IOrder CreateOrder()
        {
            string className = AssemblyName + "." + db + "Order";
            return (IOrder)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static  IManagers CreateManagers()
        {
            string className = AssemblyName + "." + db + "Managers";
            return (IManagers)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IFound CreateFound()
        {
            string className = AssemblyName + "." + db + "Found";
            return (IFound)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IFoster CreateFoster()
        {
            string className = AssemblyName + "." + db + "Foster";
            return (IFoster)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IFind CreateFind()
        {
            string className = AssemblyName + "." + db + "Find";
            return (IFind)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IDynamic CreateDynamic()
        {
            string className = AssemblyName + "." + db + "Dynamic";
            return (IDynamic)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IComments CreateComment()
        {
            string className = AssemblyName + "." + db + "Comments";
            return (IComments)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static ICollect CreateCollect()
        {
            string className = AssemblyName + "." + db + "Collect";
            return (ICollect)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static ICategories CreateCategories()
        {
            string className = AssemblyName + "." + db + "Categories";
            return (ICategories)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IAct CreateAct()
        {
            string className = AssemblyName + "." + db + "Act";
            return (IAct)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
