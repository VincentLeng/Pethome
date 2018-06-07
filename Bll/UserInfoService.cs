using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Models;
using DALFactory;
using System.Data.SqlClient;
using System.Data;
//Bll层就是调用IDAL层的方法


namespace Bll
{
    public class UserInfoService
    {
        private static IUserInfo iuserinfo = DataAccess.CreateUser();
        public static int Insert(UserInfo us)
        {
            return iuserinfo.Insert( us); 
        }
        public static SqlDataReader Login(string name, string pwd)
        {
            return iuserinfo.Login(name, pwd);
        }
    }
       
}
