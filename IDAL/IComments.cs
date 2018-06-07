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
    public interface IComments
    {
        DataTable SelectByActID(int id);
        DataTable SelectByUserID(int id);
        int insert(Comments Comm);
        DataTable SelectComments(int ActID);
        DataTable SelectAllComments();
        int DeleteComments(int ComID);

    }
}
