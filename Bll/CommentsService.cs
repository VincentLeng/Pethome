using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using DAL;
using DALFactory;
using System.Data.SqlClient;
using System.Data;
using Models;


namespace Bll
{
   public static class CommentsService
    {
        private static IComments IComments = DataAccess.CreateComment();

        public static int insert(Comments Comm)
        {
            return IComments.insert(Comm);
        }
       

        public static DataTable SelectByActID(int id)
        {
            return IComments.SelectByActID(id);
        }

        public static DataTable SelectByUserID(int id)
        {
            return IComments.SelectByUserID(id);
        }
        //留言
        public static DataTable SelectComments(int ActID)
        {
            return IComments.SelectComments(ActID);
        }
        public static DataTable SelectAllComments()
        {
            return IComments.SelectAllComments();
        }
        public static int DeleteComments(int ComID)
        {
            return IComments.DeleteComments(ComID);
        }

        public static int InsertComments(Comments comments)
        {
            return IComments.insert(comments);
        }
    }
}
