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
    public partial class ZhaoHui : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            BindFoundContent();
            //if (!IsPostBack)
            //{
            //    BindFoundContent();

            //}
        }
        private void BindFoundContent()
        {
            DataTable dt = Bll.FoundService.SelectTopTwelve();
            if (dt != null && dt.Rows.Count > 0)
            {
                LvFoundContent.DataSource = dt;
                LvFoundContent.DataBind();
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Session["UserID"] = 1;
            if (IsValid)
            {
                try
                {
                    Found us = new Found();
                    us.UserID = Int32.Parse(Session["UserID"].ToString());

                    us.FoundLostAdd = TbFoundLostAdd.Text.Trim();
                    us.FoundLostTime = DateTime.Parse(TbFoundLostTime.Text.Trim());
                    us.FoundUserPhone = TbFoundUserPhone.Text.Trim();
                    us.FoundStatus = TbFoundStatus.Text.Trim();
                    us.FoundPetPhoto = TbFoundPetPhoto.Text.Trim();
                    us.FoundContent = TbFoundContent.Text.Trim();

                    int i = FoundService.insert(us);
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