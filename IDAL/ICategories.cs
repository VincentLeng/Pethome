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
    public interface ICategories
    {
        DataTable SelectByProductID(int id);
        int IntsertCategories(ICategories cate);
        DataTable SelectAll();
    }
}
