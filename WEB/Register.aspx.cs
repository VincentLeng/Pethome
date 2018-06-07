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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                try
                {
                    UserInfo us = new UserInfo();
                    us.UserName = username.Text.Trim();
                    us.Password = password.Text.Trim();
                    us.Email = email.Text.Trim();
                    us.UserPhone = phone.Text.Trim();

                    int i = UserInfoService.Insert(us);
                    if (i >= 1)
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('注册成功！');location='Login.aspx'</script>");
                    }

                }
                catch (Exception ex)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('注册失败！失败原因如下：" + ex.Message + "');</script>");
                    Response.Write("错误原因：" + ex);
                }

            }


        }


    }
    }
