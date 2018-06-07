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
    public partial class Activity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            BindActName();
        }
        private void BindActName()
        {
            DataTable dt = Bll.ActService.SelectTopEleven();
            if (dt != null && dt.Rows.Count > 0)
            {
                LvAct.DataSource = dt;
                LvAct.DataBind();
            }
        }
    }
}