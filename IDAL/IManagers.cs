using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;

namespace IDAL
{
    public interface IManagers
    {
        int Insert(Managers us);
        SqlDataReader Login(int name, string pwd);
    }
}
