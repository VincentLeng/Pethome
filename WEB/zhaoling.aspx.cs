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
    public partial class zhaoling : System.Web.UI.Page
    {
        
    protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;        
            BindFindContent();
        }
       
        private void BindFindContent()
        {
            DataTable dt = Bll.FindService.SelectTopTwelve();
            if (dt != null && dt.Rows.Count > 0)
            {
                LvFindContent.DataSource = dt;
                LvFindContent.DataBind();
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Session["UserID"] = 1;
            if (IsValid)
            {
                try
                {
                    Find us = new Find();
                    us.UserID = Int32.Parse(Session["UserID"].ToString());
                    
                    us.FindAdd = TbFindAdd.Text.Trim();
                    us.FindTime = DateTime.Parse(TbFindTime.Text.Trim());
                    us.FindUserPhone = TbFindUserPhone.Text.Trim();
                    us.FindStatus = TbFindStatus.Text.Trim();
                    us.FindPetPhoto = TbFindPetPhoto.Text.Trim();
                    us.FindContent = TbFindContent.Text.Trim();

                    int i = FindService.insert(us);
                    if (i >= 1)
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('提交成功！');location='zhaoling.aspx'</script>");
                    }
                }
                catch (Exception ex)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('提交失败！失败原因如下：" + ex.Message + "');</script>");
                    Response.Write("错误原因：" + ex);
                }

            }
        }


    }
}