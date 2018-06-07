using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using IDAL;
using DAL;
using DALFactory;
using System.Data.SqlClient;
using System.Data;


namespace Bll
{
    public class ReplyCommentsService
    {
        private static IReplyComments iReplyComments = DataAccess.CreateReplyComments();

        //public static int insertReply(ReplyComments ReplyCom)
        //{
        //    return iReplyComments.insertReply(ReplyCom);
        //}

        //public static DataTable SelectByCommentsID(int ComID)
        //{
        //    return iReplyComments.SelectByCommentsID(ComID);
        //}

        //public DataTable SelectByUserID(int id)
        //{
        //    return iReplyComments.SelectByUserID(id);
        //}
        //留言
        public static DataTable SelectReplyComments(int ComID)
        {
            return iReplyComments.SelectReplyComments(ComID);
        }
        public static DataTable SelectAllReplyComments()
        {
            return iReplyComments.SelectAllReplyComments();
        }
        public static int DeleteReplyComments(int ReplyComID)
        {
            return iReplyComments.DeleteReplyComments(ReplyComID);
        }

        public static int InsertReplyComments(ReplyComments replyComments)
        {
            //throw new NotImplementedException();
            return iReplyComments.InsertReplyComments(replyComments);
        }
    }
}
