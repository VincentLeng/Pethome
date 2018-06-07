using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;
using System.Data;

namespace IDAL
{
    public interface IFound
    {
        DataTable SelectByUserID(int id);
        int insert(Found fou);
        DataTable selectTopOne();
        DataTable selectTopTwelve();
        DataTable SelectFoundID(int FoundID);
    }
}
