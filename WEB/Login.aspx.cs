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

namespace WEB
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            System.Text.Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            string name = username.Text.Trim();
            string pwd = password.Text.Trim();
            try
            {
                SqlDataReader UserDr =UserInfoService.Login(name, pwd);
                if (UserDr.Read())
                {
                    Session["UserName"] = username.Text;
                    Session["UserID"] = UserDr["UserID"].ToString();
                    Label1.Text = "登陆成功";
                    Response.Redirect("~/Index.aspx");
                }
                else
                {
                    Label1.Text = "用户名或密码错误";
                    password.Text = "";
                    password.Focus();
                }

            }
            catch (Exception ex)
            {
                Response.Write("错误原因：" + ex);
            }
        }
    }
    }
