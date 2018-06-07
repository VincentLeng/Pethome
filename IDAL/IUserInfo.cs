using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;

namespace IDAL
{
    public interface IUserInfo
    {
        int Insert(UserInfo us);
        SqlDataReader Login(string name, string pwd);
    }
}
