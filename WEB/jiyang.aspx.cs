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
    public partial class jiyang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            BindFosterContent();
        }

        private void BindFosterContent()
        {
            DataTable dt = Bll.FosterService.SelectTopTwelve();
            if (dt != null && dt.Rows.Count > 0)
            {
                LvFosterContent.DataSource = dt;
                LvFosterContent.DataBind();
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Session["UserID"] = 1;
            if (IsValid)
            {
                try
                {
                    Foster us = new Foster();
                    us.UserID = Int32.Parse(Session["UserID"].ToString());

                    us.FosterAdd = TbFosterAdd.Text.Trim();
                    us.FosterTime = DateTime.Parse(TbFosterTime.Text.Trim());
                    us.FosterUserPhone = TbFosterUserPhone.Text.Trim();
                    us.FosterStatus = TbFosterStatus.Text.Trim();
                    us.FosterPetPhoto = TbFosterPetPhoto.Text.Trim();
                    us.FosterContent = TbFosterContent.Text.Trim();

                    int i = FosterService.insert(us);
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