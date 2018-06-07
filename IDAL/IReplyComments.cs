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
    public interface IReplyComments
    {
        //DataTable SelectByCommentsID(int id);
        //DataTable SelectByUserID(int id);
        int InsertReplyComments(ReplyComments ReplyCom);
        //留言
        DataTable SelectReplyComments(int ComID);
        DataTable SelectAllReplyComments();
        int DeleteReplyComments(int ReplyComID);
    }
}
