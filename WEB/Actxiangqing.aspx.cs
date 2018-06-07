using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALFactory;
using System.Data.SqlClient;
using System.Data;
using Bll;
using Models;

namespace WEB
{
    public partial class Actxiangqing : System.Web.UI.Page
    {
        static bool visibleflag;
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                ViewState["ActID"] = Convert.ToInt32(Request.QueryString["id"]);
                visibleflag = true;
                BindMessage();
            }
            BindActID();
            
        }
        private void BindActID()
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            DataTable dt = ActService.SelectActID(id);
            if (dt != null && dt.Rows.Count > 0)
            {
                LvActxq.DataSource = dt;
                LvActxq.DataBind();
            }

        }

        //发布评论
        protected void btnMessage_Click(object sender, EventArgs e)
        {
            //Session["UserID"] = 1;
            if (Session["UserName"] != null)
            {
                if (Page.IsValid)
                {
                    int UserID = Convert.ToInt32(Session["UserID"]);
                    int ActID = Convert.ToInt32(Request.QueryString["id"]);
                    Comments Comments = new Comments();
                    Comments.UserID = UserID;
                    Comments.ActID = ActID;
                    Comments.ComContent = txtMessage.Text.Trim();
                    Comments.ComTime = DateTime.Now;
                    int result = CommentsService.InsertComments(Comments);
                    if (result >= 1)
                    {
                        ScriptManager.RegisterClientScriptBlock(MessageUpdatePanel, this.GetType(), "click", "alert('留言成功')", true);
                        BindMessage();
                        txtMessage.Text = "";
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(MessageUpdatePanel, this.GetType(), "click", "alert('留言失败')", true);
                    }
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(MessageUpdatePanel, this.GetType(), "click", "alert('您必须先登录才能发表评论');", true);
                ScriptManager.RegisterStartupScript(MessageUpdatePanel, MessageUpdatePanel.GetType(), "updateScript", "window.location.href='Login.aspx'", true);
            }



        }
        //绑定评论信息
        private void BindMessage()
        {
            int id = Convert.ToInt32(ViewState["ActID"]);
            DataTable dt = CommentsService.SelectComments(id);
            if (dt != null && dt.Rows.Count > 0)
            {
                MessageListView.DataSource = dt;
                MessageListView.DataBind();
            }
        }
        //找到回复按钮
        protected void lkbtnReply_Click(object sender, EventArgs e)
        {
            LinkButton bt = (LinkButton)sender;
            Panel panelreply = bt.Parent.FindControl("ReplyPanel") as Panel;
            panelreply.Visible = true;
            visibleflag = !visibleflag;
        }
        //回复评论
        protected void btnRply_Click(object sender, EventArgs e)
        {
            if (Session["UserName"] != null)
            {
                if (Page.IsValid)
                {
                    LinkButton btn = (LinkButton)sender;
                    int UserID = Convert.ToInt32(Session["UserID"]);
                    ReplyComments ReplyComments = new ReplyComments();
                    ReplyComments.ComID = Int32.Parse((btn.Parent.FindControl("HiddenFieldComID") as HiddenField).Value);
                    ReplyComments.UserID = UserID;
                    ReplyComments.ReplyComContent = ((TextBox)btn.Parent.FindControl("txtReplyContent")).Text;
                    ReplyComments.ReplyComTime = DateTime.Now;
                    int result = ReplyCommentsService.InsertReplyComments(ReplyComments);
                    if (result >= 1)
                    {
                        ScriptManager.RegisterClientScriptBlock(ReplyUpdatePanel, this.GetType(), "click", "alert('回复成功')", true);
                        visibleflag = true;
                        BindMessage();

                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(ReplyUpdatePanel, this.GetType(), "click", "alert('回复失败')", true);
                    }
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(ReplyUpdatePanel, this.GetType(), "click", "alert('您必须先登录才能发表评论');", true);
                ScriptManager.RegisterStartupScript(ReplyUpdatePanel, MessageUpdatePanel.GetType(), "updateScript", "window.location.href='Login.aspx'", true);
            }
        }
        //绑定回复留言
        protected void lvComments_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                HiddenField hiddenComID = e.Item.FindControl("HiddenFieldComID") as HiddenField;
                int ComID = int.Parse(hiddenComID.Value);
                Repeater rpt = e.Item.FindControl("ReplyRepeater") as Repeater;

                DataTable dt = ReplyCommentsService.SelectReplyComments(ComID);

                if (dt != null && dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;
                    rpt.DataBind();
                }
            }
        }
        //protected void DataPager1_PreRender(object sender, EventArgs e)
        //{
        //    if (visibleflag == true)
        //    {
        //        BindMessage();
        //    }
        //}
    }

}