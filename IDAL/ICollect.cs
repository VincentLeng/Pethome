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
    public interface ICollect
    {
        DataTable SelectByProductsID(int id);
        DataTable SelectByUserID(int id);
        int insert(Collect coll);
    }
}
