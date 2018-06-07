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
    public interface IAct
    {
        DataTable SelectByUserID(int id);
        int InsertActs(Act Act);
        //补充功能，用代码实现对这张表进行操作    desc表示降序排列
        DataTable SelectTopEleven();
        DataTable SelectActID(int ActID);
    }
}
