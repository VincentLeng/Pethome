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
    public interface IFoster
    {
        DataTable SelectByUserID(int id);
        int insert(Foster fos);
        DataTable selectTopOne();
        DataTable selectTopTwelve();
        DataTable SelectFosterID(int FosterID);
    }
}
